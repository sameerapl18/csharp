using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Services.ServiceOrder.NewServiceOrder_Main
{
   
    public partial class NewServiceOrder_Main : Utilities.Documents.Documents_Main
    {
       public static List<double> addedservices = new List<double>();
         public NewServiceOrder_Main(IdentityObject ident)
        {
            InitializeComponent();
            LoadServiceTypes();
            textBox_DocType.Text = "22";
            DataTable dt = Utilities.DataBaseUtility.GetTable("select * from ServiceOrders");
            int docNum = dt.Rows.Count;
            double docnum = 0;
           // Console.Write(docNum);
            if (docNum == 0)
            {
                docnum = 201;
            }
            else
            {
                Object temp = dt.Rows[docNum - 1][0];
                //Console.Write(temp);
                 docnum = Convert.ToDouble(temp) + 1;
            }
            textBox_DocNum.Text = docnum.ToString();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
         protected virtual void LoadServiceTypes()
         {    // (1) Download a List of DocTypes
             //   DataTable queryTable = new DataTable();
             List<string> queryList = Utilities.DataBaseUtility.GetList("select * from Services where Avaliabilty='Y'");
             int numReturned = queryList.Count - 1;
             ComboBox_2.Items.Clear();
             ComboBox_2.Items.Add(" 0 , no type selected");
             for (int i = 1; i <= numReturned; i++)
             {
                 string[] fields = queryList[i].Split(',');
                 ComboBox_2.Items.Add(fields[3] + "  .  " + fields[16]);

             }
         }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label_SubName_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            int docNum = Convert.ToInt32(textBox_DocNum.Text);
            double docType = Convert.ToInt32(textBox_DocType.Text);
            double customerID = Convert.ToInt32(textBox3.Text);
            double ServiceOrderID = docNum;
            double status = 0;
            double docref = docNum;
            string startDate = textBox9.Text;
            string endDate = textBox8.Text;
            string ServiceReq = ComboBox_2.Text;
            ServiceReq = ServiceReq.Substring(0, 2);
            double servicereq = Convert.ToDouble(ServiceReq);
            Console.WriteLine(servicereq);
            int crewSize = Convert.ToInt32(textBox6.Text);
            int noOfdays = 0;
            DateTime startDate1 = Convert.ToDateTime(startDate);
            Console.WriteLine(startDate1);
            DateTime endDate1 = Convert.ToDateTime(endDate);
            TimeSpan diff = endDate1.Subtract(startDate1);
            double count = diff.Days;
            double numval = 0;
            double totalprice = 0;
            Console.WriteLine("nuber of days" + count);
            Console.WriteLine("service requested " + ServiceReq);
            string servicesDescresult = "";
            DataTable dt = Utilities.DataBaseUtility.GetTable("select DocNum from ProcessDocs where DocType=22");
            int processdocid = dt.Rows.Count;
            double processdocid1;
            // Console.Write(docNum);
            if (processdocid == 0)
            {
                processdocid1 = 701;
            }
            else
            {
                Object temp = dt.Rows[processdocid - 1][0];
                //Console.Write(temp);
                processdocid1 = Convert.ToDouble(temp) + 1;
            }
            int index = 0;
            if(addedservices.Count==0)
            {
                addedservices.Add(servicereq);
            }
            for (int i = 0; i < addedservices.Count; i++)
            {
                List<string> servicetypes = Utilities.DataBaseUtility.GetList("select ServiceDescription,StdPrice,EmployeeSize from Services where ServiceType=" + addedservices[i] + "");
                string[] values = servicetypes[1].Split(',');
                string serviceType = values[0];
                double stdprice = Convert.ToDouble(values[1]);
                double empsize = Convert.ToDouble(values[2]);
                double temptotalprice1 = 0;
                servicesDescresult = servicesDescresult + "&" + serviceType;
                double temptotalPrice = 0;
                double individualPrice = 0;
                if (crewSize > empsize)
                {
                    double temp1 = crewSize / empsize;
                    temptotalprice1 = temp1 * stdprice;
                    totalprice = totalprice + temptotalprice1;
                    individualPrice = temptotalprice1;
                }
                else
                {
                    totalprice = stdprice;
                }
                if (count > 1)
                {
                    temptotalPrice = stdprice * count;
                    totalprice = totalprice + temptotalPrice;
                    individualPrice = temptotalprice1 + temptotalPrice;
                }
               
                IdentityObject ident = new IdentityObject();
                IdentityObject ident1 = new IdentityObject();
                string output = Utilities.DataBaseUtility.Execute(("insert into ServiceOrders_Details values(" + docNum + "," + docType + "," + addedservices[i] + "," + 0 + "," + crewSize + "," + count + "," + stdprice + ",'" + textBox5.Text + "')"), ident);
                string output1 = Utilities.DataBaseUtility.Execute(("insert into ProcessDocs_Details values(" + processdocid1 + "," + docType + "," + index + "," + 0 + "," + processdocid1 + "," + 1 + "," + individualPrice + ",'" + textBox5.Text + "')"), ident1);
                Console.WriteLine(output);
                index++;
              

            }
           IdentityObject ident2 = new IdentityObject();
          IdentityObject ident3 = new IdentityObject();
          string Output = Utilities.DataBaseUtility.Execute(("insert into ServiceOrders values(" + docNum + "," + docType + "," + ServiceOrderID + "," + customerID + "," + status + "," + docref + ",'" + startDate1 + "','" + endDate1 + "'," + numval + "," + totalprice + ",'" + servicesDescresult +"',"+0+")"), ident2);
           string Output1 = Utilities.DataBaseUtility.Execute(("insert into ProcessDocs values(" + processdocid1 + "," + docType + "," + 0 + "," + 0 + "," + status + "," + processdocid1 + ",'" + startDate1 + "','" + endDate1 + "'," + totalprice + "," + totalprice + ",'" + servicesDescresult + "')"), ident3);
            Console.WriteLine(Output);
            this.Close();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            string ServiceReq = ComboBox_2.Text;
            ServiceReq = ServiceReq.Substring(0, 2);
            double servicereq = Convert.ToDouble(ServiceReq);
            addedservices.Add(servicereq);
            String display = "";
            for(int i=0;i<addedservices.Count;i++)
            {
                display = display + " , " + Convert.ToString(addedservices[i]);
            }
            label11.Enabled = true;
            label11.Visible = true;
            label11.Text = "Selected Service Types are : " + display;
            ComboBox_2.SelectedIndex = 0;

        }
    }
}
