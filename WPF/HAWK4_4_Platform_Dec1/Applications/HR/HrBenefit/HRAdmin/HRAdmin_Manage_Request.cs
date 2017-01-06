using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//11-11-2016 patty: this page is for HR admin to review the benefits request from employees
namespace Applications.Applications.HR.HrBenefit.HRAdmin
{
    public partial class HRAdmin_Manage_Request : HAWK_Template_2
    {
        protected DataTable _documentValues;
        public HRAdmin_Manage_Request()
        {
            InitializeComponent();
        }
        public HRAdmin_Manage_Request(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }


        //label1.Text = "select e1.DocNum,e1.EmpID,e2.reqID from EmployeeBenefits as e1 left outer join EmployeeBenefits_Details as e2 on e1.DocNum = e2.DocNum" ;

            //display all request
        private void button_show_req_Click(object sender, EventArgs e)
        {

            String query = "select e1.DocNum,e1.DocType,e2.docRef,e1.EmpID,e2.reqID, e2.Comment from EmployeeBenefits as e1 left outer join EmployeeBenefits_Details as e2 "
                + "on e1.DocNum = e2.DocNum where e2.reqstatus = 1";
            try
            {
                string cmdStr2 = String.Format(query);
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView1.DataSource = _documentValues;
                DataGridViewColumn column0 = dataGridView1.Columns[0];
                column0.Width = 80;
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.Width = 80;
                DataGridViewColumn column2 = dataGridView1.Columns[2];
                column2.Width = 80;
                DataGridViewColumn column3 = dataGridView1.Columns[3];
                column3.Width = 80;
                DataGridViewColumn column4 = dataGridView1.Columns[4];
                column4.Width = 80;
                DataGridViewColumn column5 = dataGridView1.Columns[5];
                column5.Width = 310;
               





            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading GenDocs " + ex.Message);
            }
        }

        // click record can choose either approve or reject the particular request
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docRefStr = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string empIdStr = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string reqIdStr = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string reqStatusStr = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            //MessageBox.Show(reqStatusStr);

            DialogResult diaRes = MessageBox.Show("Employee ID = " + empIdStr + ", Request ID = " + reqIdStr 
                + " \n Would you like to approve this request?", "Manage Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (diaRes == DialogResult.Yes) //approve request
            {
                try
                {
                    // String percentGive = "";
                    //  percentGive = Interaction.InputBox("How many percent you would like to give? ");
                    List<string> _records = new List<string>();
                    try
                    {
                        //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                        _records = Utilities.DataBaseUtility.GetList("select * from Benefits where docNum = " + docRefStr);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("  error in reading table : select * from Benefits_Details where docNum = " + docRefStr, ex.Message);
                        return;
                    }

                    _records.RemoveAt(0);

                    string[] _documentValues = _records[0].Split(',');
                    String benefit_percent = _documentValues[2].ToString();

                    //if (reqStatusStr == "new open request for adding benefit") //[nidhi] bug fix for benefit counts when approve request for add benefit
                    if (reqStatusStr.Contains("open request status")) //[nidhi] bug fix for benefit counts when approve request for add benefit
                    {
                        //update EmployeeBenefits_Details
                        String uEmpBenD = "update EmployeeBenefits_Details set reqStatus = 2, approverEmpID = " + label_UserID.Text +
                            ", approvedPercent = " + benefit_percent + ", Comment = 'Benefit " + docRefStr + " with the approved add benefit request status'"
                            + " where DocNum = " + docNumStr + " and reqID = " + reqIdStr;
                        DataTable dTable = Utilities.DataBaseUtility.GetTable(uEmpBenD);

                        //update EmployeeBenefits
                        String uEmpBen = "update EmployeeBenefits set approvedCount = approvedCount + 1, totalBenPercent = totalBenPercent + " + benefit_percent +
                            " where DocNum = " + docNumStr + " and EmpID = " + empIdStr;
                        DataTable dTable2 = Utilities.DataBaseUtility.GetTable(uEmpBen);

                        //update Benefits, for Benefit Type 1 or 2
                        String uBen = "update Benefits set benefitCount = benefitCount + 1, comment = benefitCount + 1 & 'employees are using mandatory benefit " + docRefStr +
                         "' where DocNum = " + docRefStr + " and benefitType = 2";
                        String uBen2 = "update Benefits set benefitCount = benefitCount + 1, comment = benefitCount + 1 & 'employees are using optional benefit " + docRefStr +
                         "' where DocNum = " + docRefStr + " and benefitType = 1";
                        DataTable dTable3 = Utilities.DataBaseUtility.GetTable(uBen);  //for Benefit type 2
                        DataTable dTable4 = Utilities.DataBaseUtility.GetTable(uBen2); //for Benefit type 1
                    }
                    else if (reqStatusStr.Contains("open delete request status")) ////[nidhi] bug fix for benefit counts when approve request for delete benefit
                    {
                        ////update EmployeeBenefits_Details
                        ////String uEmpBenD = "update EmployeeBenefits_Details set reqStatus = 2, approverEmpID = " + label_UserID.Text +
                        //    ", approvedPercent = 0, Comment = 'Benefit " + docRefStr + " with the approved delete benefit request status'"
                        //    + " where DocNum = " + docNumStr + " and reqID = " + reqIdStr;
                        ////DataTable dTable = Utilities.DataBaseUtility.GetTable(uEmpBenD);
                                              

                        String uEmpBenD = "delete from EmployeeBenefits_Details where reqStatus = 1 and DocNum = " + docNumStr + " and reqID = " + reqIdStr;
                        DataTable dTable = Utilities.DataBaseUtility.GetTable(uEmpBenD);
                        
                        //update EmployeeBenefits
                        String uEmpBen = "update EmployeeBenefits set approvedCount = approvedCount - 1, benCount = benCount - 1 where DocNum = " + docNumStr + " and EmpID = " + empIdStr;
                        DataTable dTable2 = Utilities.DataBaseUtility.GetTable(uEmpBen);

                        //update Benefits, for Benefit Type 1 or 2
                        String uBen = "update Benefits set benefitCount = benefitCount - 1, comment = benefitCount - 1 & 'employees are using mandatory benefit " + docRefStr +
                         "' where DocNum = " + docRefStr + " and benefitType = 2";
                        String uBen2 = "update Benefits set benefitCount = benefitCount - 1, comment = benefitCount - 1 & 'employees are using optional benefit " + docRefStr +
                         "' where DocNum = " + docRefStr + " and benefitType = 1";
                        DataTable dTable3 = Utilities.DataBaseUtility.GetTable(uBen);  //for Benefit type 2
                        DataTable dTable4 = Utilities.DataBaseUtility.GetTable(uBen2); //for Benefit type 1
                    }

                    MessageBox.Show("The request from empID " + empIdStr + " has been approved! \n Request ID = " + reqIdStr);
                    return;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("  error in reading GenDocs " + ex.Message);
                }             



            }
            else if (diaRes == DialogResult.No)  //reject request
            {

                try
                {
                    //if (reqStatusStr == "new open request for adding benefit") //[nidhi] bug fix for benefit counts when reject request for add benefit
                    if (reqStatusStr.Contains("open request status")) //[nidhi] bug fix for benefit counts when reject request for add benefit
                    {
                        
                        String dEmpBenD = "delete from EmployeeBenefits_Details  where DocNum = " + docNumStr + " and reqID = " + reqIdStr + " and reqStatus = 1";

                        DataTable dTable = Utilities.DataBaseUtility.GetTable(dEmpBenD);

                        
                        String uEmpBen = "update EmployeeBenefits set benCount = benCount - 1 where DocNum = " + docNumStr + " and EmpID = " + empIdStr;

                        DataTable dTable2 = Utilities.DataBaseUtility.GetTable(uEmpBen);

                        MessageBox.Show("The request from empID " + empIdStr + " has been rejected! \n Request ID = " + reqIdStr);
                        return;
                    }
                    else if (reqStatusStr.Contains("open delete request status")) ////[nidhi] bug fix for benefit counts when reject request for delete benefit
                    {
                        //shud we delete this record or no action?
                        //String dEmpBenD = "delete from EmployeeBenefits_Details  where DocNum = " + docNumStr + " and reqID = " + reqIdStr + " and reqStatus = 1";

                        String dEmpBenD = "update EmployeeBenefits_Details set reqStatus = 2, comment = 'Benefit " + docRefStr + " with the approved request status' where DocNum = " + docNumStr + " and reqID = " + reqIdStr + " and reqStatus = 1";
                        
                        DataTable dTable = Utilities.DataBaseUtility.GetTable(dEmpBenD);

                        //no action here, so commented below 2 lines
                        //String uEmpBen = "update EmployeeBenefits set benCount = benCount - 1 where DocNum = " + docNumStr + " and EmpID = " + empIdStr;

                        //DataTable dTable2 = Utilities.DataBaseUtility.GetTable(uEmpBen);

                        MessageBox.Show("The request from empID " + empIdStr + " has been rejected! \n Request ID = " + reqIdStr);
                        return;
                    }

                    }
                catch (Exception ex)
                {
                    MessageBox.Show("  error in reading GenDocs " + ex.Message);
                }


            }




        }
    }
}
