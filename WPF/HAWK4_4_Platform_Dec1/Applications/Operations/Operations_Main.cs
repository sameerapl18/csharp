﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations
{
    public partial class Operations_Main : Applications.Operations.Operations_Template
    {
        public Operations_Main()
        {
            InitializeComponent();
        }
        public Operations_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Applications.Operations.Employee.Employee_Main(ident).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Applications.Operations.Admin.Admin_Main(ident).Show();
        }



          private void button3_Click_1(object sender, EventArgs e)
           {
               Operations.Report1 rept = new Operations.Report1();
               CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
               CR_Form.crystalReportViewer1.ReportSource = rept;
               CR_Form.Show();

           }
       
    }
}
