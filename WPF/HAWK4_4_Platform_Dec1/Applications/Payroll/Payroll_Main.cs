﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using Utilities.Documents;
using Utilities;

namespace Applications.Applications.Payroll
{
    public partial class Payroll_Main : Applications.Payroll.Payroll_Template
    {
        //static int emp_id = 104;
        public Payroll_Main()
        {
            //emp_id = 104;
            InitializeComponent();
        }
        public Payroll_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void Payroll_Main_Load(object sender, EventArgs e)
        {
            String Salaried;
            String Hourly;
            String Status = "salaried";
            bool flag = true;

           // panel1.Visible = true;
            PictureBox p = new PictureBox();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           // panel1.Visible = true;
            //button9.Hide();
            //panel3.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //panel3.Visible = true;
           // panel1.Visible = true;
            //button9.Show
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // new Payroll.SalariedEmp_GrossPay().Show();
            new Payroll.PayCheck("grosspay",Convert.ToInt32(ident.UserID)).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          // new Payroll.NetPay_SalariedEmpl().Show();
            new Payroll.PayCheck("netpay", Convert.ToInt32(ident.UserID)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new Payroll.PayCheck("payslip", Convert.ToInt32(ident.UserID)).Show();
           // new Payroll.SalariedEmp_Benefits().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Payroll.TimeSheet(ident).Show();
          //  new Payroll.Deductions.SalariedEmp_Deductions().Show();
        }

        private void charts_Click(object sender, EventArgs e)
        {
           // IdentityObject ident  = new IdentityObject();
            new Payroll.Charts(ident, Convert.ToInt32(ident.UserID)).Show();

        }

        private void btnCrystal_Click(object sender, EventArgs e)
        {
            new Payroll.Crystal().Show();
        }
    }
}
