using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Services
{
    public partial class Customer : Utilities.Documents.Documents_Main
    {
        
              public Customer(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox16.Text = "2";
            DataTable dt = Utilities.DataBaseUtility.GetTable("select * from Customers");
            int docNum = dt.Rows.Count;
            // Console.Write(docNum);
            Object temp = dt.Rows[docNum - 1][0];
            //Console.Write(temp);
            double docnum = Convert.ToDouble(temp) + 1;
            textBox1.Text = docnum.ToString();
        }
        

        private void label_SubName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int DocNum = Convert.ToInt32(textBox1.Text);
            double DocType = Convert.ToDouble(textBox16.Text);
            String Firstname = textBox15.Text;
            String lastname = textBox14.Text;
            String AddressLine1 = textBox13.Text;
            String AddressLine2 = textBox12.Text;
            String city = textBox11.Text;
            String state = textBox10.Text;
            String zipcode = textBox9.Text;
            String country = textBox8.Text;
            String phoneNum = textBox7.Text;
            String emailid = textBox6.Text;
            String comments = textBox5.Text;

           IdentityObject ident = new IdentityObject();
            string Output = Utilities.DataBaseUtility.Execute(("insert into Customers values(" + DocNum + "," + DocType + ",'" + Firstname + "','" + lastname + "','" + AddressLine1 + "','" + AddressLine2 + "','" + city + "','" + state + "','" + zipcode + "','" + country + "','" + phoneNum + "','" + null + "','" + emailid + "','" + null + "','" + null + "','" + null + "','" + comments + "')"), ident);
           // Utilities.Documents.ListObjects pds = new Utilities.Documents.ListObjects(base.ident); pds.Show();
            new Applications.Sales.Services.Services(base.ident).Show();

        }
    }
}
