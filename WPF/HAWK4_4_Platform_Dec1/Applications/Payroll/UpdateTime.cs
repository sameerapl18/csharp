using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class UpdateTime : HAWK_Template_2
    {
        string y;

        public UpdateTime(IdentityObject ident)
        {
            InitializeComponent();
            label_UserID.Text = ident.UserID;
            label_UserName.Text = ident.UserName;
        }

        public void UpdateDetails(int EMP_ID, int week)
        {
            lblEmp.Text = EMP_ID.ToString();
            lblWeek.Text = week.ToString();

            string res = "select * from Timesheets where Emp_ID=" + EMP_ID + " and Week_Id=" + week;

            List<string> s = Utilities.DataBaseUtility.GetList(res, ',');

            y = s[1].Split(',')[0];

            lblStart.Text = s[1].Split(',')[6];

            lblEnd.Text = s[1].Split(',')[7];


            string res1 = "select * from TimeSheets_Details where Emp_ID=" + EMP_ID + " and DocNum=" + y;

            List<string> s1 = Utilities.DataBaseUtility.GetList(res1, ',');


            dataGridView1.ColumnCount = 2;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].Name = "WeekDay";
            dataGridView1.Columns[1].Name = "Num of hours";

            string[] row = new string[s1.Count];

            for (int i = 1; i < s1.Count; i++)
            {
                string[] r = s1[i].Split(',');
                if (r[3].Trim() == "1")
                {
                    row = new string[] { "Monday", s1[i].Split(',')[4] };
                    dataGridView1.Rows.Add(row);
                }

                if (r[3].Trim() == "2")
                {
                    row = new string[] { "Tuesday", s1[i].Split(',')[4] };
                    dataGridView1.Rows.Add(row);
                }

                if (r[3].Trim() == "3")
                {
                    row = new string[] { "Wednesday", s1[i].Split(',')[4] };
                    dataGridView1.Rows.Add(row);
                }

                if (r[3].Trim() == "4")
                {
                    row = new string[] { "Thursday", s1[i].Split(',')[4] };
                    dataGridView1.Rows.Add(row);
                }

                if (r[3].Trim() == "5")
                {
                    row = new string[] { "Friday", s1[i].Split(',')[4] };
                    dataGridView1.Rows.Add(row);
                }

            }


            //for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //{
            //    string hours = dataGridView1[1, i].Value.ToString();


            //}



            //row = new string[] { "Monday", s1[1].Split(',')[4] };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "Tuesday", s1[2].Split(',')[4] };
            //dataGridView1.Rows.Add(row);

            //row = new string[] { "Wednesday", s1[3].Split(',')[4] };
            //dataGridView1.Rows.Add(row);

            //row = new string[] { "Thursday", s1[4].Split(',')[4] };
            //dataGridView1.Rows.Add(row);

            //row = new string[] { "Friday", s1[5].Split(',')[4] };
            //dataGridView1.Rows.Add(row);


        }

        private void btnSubmitTime_Click(object sender, EventArgs e)
        {
            int sum = 0;
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                // string hours = dataGridView1[1, i].Value.ToString();
                if (dataGridView1[0, i].Value.ToString() == "Monday")
                {
                    dict.Add(1, Convert.ToInt32(dataGridView1[1, i].Value));
                    sum += Convert.ToInt32(dataGridView1[1, i].Value);
                }

                else if (dataGridView1[0, i].Value.ToString() == "Tuesday")
                {
                    dict.Add(2, Convert.ToInt32(dataGridView1[1, i].Value));
                    sum += Convert.ToInt32(dataGridView1[1, i].Value);
                }


                else if (dataGridView1[0, i].Value.ToString() == "Wednesday")
                {
                    dict.Add(3, Convert.ToInt32(dataGridView1[1, i].Value));
                    sum += Convert.ToInt32(dataGridView1[1, i].Value);
                }


                else if (dataGridView1[0, i].Value.ToString() == "Thursday")
                {
                    dict.Add(4, Convert.ToInt32(dataGridView1[1, i].Value));
                    sum += Convert.ToInt32(dataGridView1[1, i].Value);
                }


                else if (dataGridView1[0, i].Value.ToString() == "Friday")
                {
                    dict.Add(5, Convert.ToInt32(dataGridView1[1, i].Value));
                    sum += Convert.ToInt32(dataGridView1[1, i].Value);
                }

            }

            bool update = true;
            foreach (var k in dict.Keys)
            {
                string cmdString2 = String.Format("Update TimeSheets_Details set Hours_Worked = {0} where Day_Of_Week = {1} and DocNum = {2} and DocType = 41 and Emp_ID = {3}",dict[k],k, Convert.ToInt32(y), Convert.ToInt32(lblEmp.Text));
                string retMessage2 = Utilities.DataBaseUtility.Execute(cmdString2, ident);



                if (!(retMessage2 == "no errors"))
                    update = false;


            }
            string cmdString1 = String.Format("Update TimeSheets set Total_Hours_Worked = {0} where DocNum = {1} and DocType = 41 and Emp_ID = {2} and Week_Id={3}", sum, Convert.ToInt32(y), Convert.ToInt32(lblEmp.Text), Convert.ToInt32(lblWeek.Text));
            string retMessage1 = Utilities.DataBaseUtility.Execute(cmdString1, ident);

            if (update == true && retMessage1 == "no errors")
                lblResult.Text = "Updated Successfully";

        }

        
    }
}