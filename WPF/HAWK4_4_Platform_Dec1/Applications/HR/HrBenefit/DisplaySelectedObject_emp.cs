using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class DisplaySelectedObject_emp : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject_emp()
        {
            InitializeComponent();
        }
        public DisplaySelectedObject_emp(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            //String userid = ident.UserID;
            //String inp = textBox_DocNum.Text;

            //string qty = "select ed.docRef from EmployeeBenefits_Details as ed, EmployeeBenefits as e where e.EmpID = '" + userid + "' and e.DocNum=ed.DocNum and ed.docRef = '" + inp + "' and ed.reqStatus = '2'";
            //int quant = Utilities.DataBaseUtility.Execute(ident, qty);
            //MessageBox.Show(quant.ToString());

            //if (quant != 1)
            //{
            //    //delete active
            //    //add inactive
            //    btn_add_benefit.Visible = false;
            //    btn_delete_benefit.Visible = true;
            //}
            //else
            //{
            //    //delete inactive
            //    //add active
            //    btn_add_benefit.Visible = true;
            //    btn_delete_benefit.Visible = false;
            //}

        }

        public DisplaySelectedObject_emp(IdentityObject ident, string tableName, string docType, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;

            button_ResetCommand_Click(this, null);

            //[Nidhi] Added for hiding and showing add and delete button
            String userid = ident.UserID;
            String inp = textBox_DocNum.Text; //docnum of benefits table
                        
            String qty = "select ed.docRef from EmployeeBenefits_Details as ed,EmployeeBenefits as e, Benefits as b where ed.DocNum = e.DocNum and ed.docref=b.docnum and ed.reqstatus = 2 and b.docnum =" + inp + " and e.empid =" + userid;

            List<String> list1 = Utilities.DataBaseUtility.GetList(qty);

            int quant = list1.Count;
            
           if (quant == 1)
            {
                //delete inactive
                //add active
                btn_add_benefit.Visible = true;
                btn_delete_benefit.Visible = false;
            }
           else
            {
                //delete active
                //add inactive
                btn_add_benefit.Visible = false;
                btn_delete_benefit.Visible = true;
            }
        }

        //[Nidhi] Added for adding/updating benefit
        private void btn_add_benefit_Click(object sender, EventArgs e)
        {            
            String userid = ident.UserID;

            //condition to checkif employee already has his record in employee benefits table

            string qq = "select DocNum from EmployeeBenefits where EmpID =" + userid;
            List<String> list2 = Utilities.DataBaseUtility.GetList(qq);
            String doc_num_emp_ben = list2[1];

            string qq1 = "select reqID from EmployeeBenefits_Details order by reqID desc";
            List<String> list3 = Utilities.DataBaseUtility.GetList(qq1);
            String doc_num_emp_ben1 = list3[1];
            //MessageBox.Show(doc_num_emp_ben1);
            int doc_num_emp_ben2 = Convert.ToInt32(doc_num_emp_ben1) + 1;

            //MessageBox.Show(doc_num_emp_ben2.ToString());            

            //MessageBox.Show(doc_num_emp_ben);

            int quant2 = list2.Count;
            String doc_num_ben = textBox_DocNum.Text;

            //MessageBox.Show(quant2.ToString());

            if (quant2 != 1)

            {                
                //Updating Employee_Benefits table
                String update_query_1 = "update EmployeeBenefits set benCount = benCount+1 where EmpID =" + userid;
                DataTable dTable = Utilities.DataBaseUtility.GetTable(update_query_1);
                //MessageBox.Show("bencount increased");
            }
            else
            {
                //verify if we need to add new records in employee benefits table

                ////int nextNum = Utilities.DataBaseUtility.GetNextNumber()
                ////string q1 = "select DocNum from EmployeeBenefits";
                ////int a1 = Utilities.DataBaseUtility.GetLastNumber(ident, q1);
                //String insert_query_0 = "insert into EmployeeBenefits values(" + doc_num_emp_ben
                //+",'65', "+ doc_num_ben + "'0','1','0','0','new open request for adding benefit')";
                //DataTable dTable0 = Utilities.DataBaseUtility.GetTable(insert_query_0);
                //MessageBox.Show("done");
            }

            //Adding new record in Employee_Benefits_details table          

            //String insert_query_1 = "insert into EmployeeBenefits_Details values(" + doc_num_emp_ben
            //    + ",'65'," + doc_num_ben + "," + doc_num_emp_ben2 + ",'1','0','0','Benefit " + doc_num_ben + " with the open request for adding benefit')";
            //DataTable dTable2 = Utilities.DataBaseUtility.GetTable(insert_query_1);

            //new open request for adding benefit

            String insert_query_1 = "insert into EmployeeBenefits_Details values(" + doc_num_emp_ben
               + ",'65'," + doc_num_ben + "," + doc_num_emp_ben2 + ",'1','0','0','Benefit " + doc_num_ben + " with the open request status')";
            //Benefit 607  with the open request status, open request status

            DataTable dTable2 = Utilities.DataBaseUtility.GetTable(insert_query_1);

            MessageBox.Show("Your request for adding the benefit has been sent to the Admin. Please wait for the approval");

            //this.Close();            
        }

        //[Nidhi] Added for deleting benefit
        private void btn_delete_benefit_Click(object sender, EventArgs e)
        {           
            String userid = ident.UserID;

            //reduce ben count on delete request

            //Bud fix [Nidhi] on delete request benCount should not be decremented
            //String update_query_2 = "update EmployeeBenefits set benCount = benCount-1 where EmpID = " + userid;
            //DataTable dTable = Utilities.DataBaseUtility.GetTable(update_query_2);

            String doc_num_ben = textBox_DocNum.Text;

            string qq2 = "select reqID from EmployeeBenefits_Details order by reqID desc";
            List<String> list4 = Utilities.DataBaseUtility.GetList(qq2);
            String doc_num_emp_ben4 = list4[1];
            //MessageBox.Show(doc_num_emp_ben1);
            int doc_num_emp_ben5 = Convert.ToInt32(doc_num_emp_ben4) + 1;

            //String update_query_3 = "update EmployeeBenefits_Details set reqID = '0', req_Status = '1', comment = 'new open request for deleting benefit' where docRef = " + doc_num_ben;
            //String update_query_3 = "update EmployeeBenefits_Details set reqID = '" + doc_num_emp_ben5 + "',reqStatus = '1', comment = 'Benefit " + doc_num_ben + " with the open request for deleting benefit' where docRef = " + doc_num_ben + " and docnum=(select docnum from EmployeeBenefits where empid =" + userid + ")";

            String update_query_3 = "update EmployeeBenefits_Details set reqID = '" + doc_num_emp_ben5 + "',reqStatus = '1', comment = 'Benefit " + doc_num_ben + " with the open delete request status' where docRef = " + doc_num_ben + " and docnum=(select docnum from EmployeeBenefits where empid =" + userid + ")";

            DataTable dTable2 = Utilities.DataBaseUtility.GetTable(update_query_3);      

            MessageBox.Show("Delete request sent successfully"); 
        }

        
    }
}
