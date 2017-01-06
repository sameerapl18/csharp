using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Admin.DisplaySpecificOrder
{
    public partial class DisplaySpecificOrder : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySpecificOrder()
        {
            InitializeComponent();
        }
        public DisplaySpecificOrder(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        public DisplaySpecificOrder(IdentityObject ident, String t, String a, String b) :  base( ident,  t,  a,  b)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    int docNum = Convert.ToInt32(textBox_DocNum.Text);
        //    double docType = Convert.ToDouble(textBox_DocType.Text);
        //    double ServiceType = Convert.ToDouble(docNum);
        //    double customerID = Convert.ToDouble(textBox_IntAgent.Text);
        //    double noOfEmp = Convert.ToDouble(textBox2.Text);
        //    double status = Convert.ToDouble(textBox_Status.Text);
        //    double docref = Convert.ToDouble(docNum);
        //    DateTime startDate = Convert.ToDateTime(textBox_TextValue1.Text);
        //    DateTime endDate = Convert.ToDateTime(textBox_TextValue2.Text);
        //    double duration = Convert.ToDouble(textBox_NumValue1.Text);
        //    double cost = Convert.ToDouble(textBox_NumValue2.Text); ;
        //    string comments = textBox_Comment.Text;
        //    double empID = Convert.ToDouble(textBox1.Text); ;
        //    double materialID = Convert.ToDouble(textBox3.Text); ;
        //    double indivPrice = Convert.ToDouble(textBox_ProcessID.Text);
        //    string serviceAllDetComments = textBox4.Text;

        //    string output = Utilities.DataBaseUtility.Execute(("insert into ServiceAllocations values(" + docNum + "," + docType + "," + ServiceType + "," + customerID + "," + noOfEmp + "," + status + ",'" + startDate + "','" + endDate + "'," + duration + ","+ cost + ",'" + comments +"')"), ident);
        //    Console.WriteLine(output);

        //    string Output = Utilities.DataBaseUtility.Execute(("insert into ServiceAllocations_Details values(" + docNum + "," + docType + "," + empID + "," + docref + "," + materialID + "," + ServiceType + "," + indivPrice + ",'" + serviceAllDetComments + "')"), base.ident);
        //    Console.WriteLine(Output);

        //    new Applications.Operations.Admin.ScheduleServiceOrder.Scheduled(base.ident).Show();


        //}
    }
}
