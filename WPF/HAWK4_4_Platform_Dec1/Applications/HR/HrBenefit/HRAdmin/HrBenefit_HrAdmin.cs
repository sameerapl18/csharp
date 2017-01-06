﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_HrAdmin : HAWK_Template_2
    {
        public HrBenefit_HrAdmin()
        {
            InitializeComponent();
        }


        public HrBenefit_HrAdmin(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_HrAdmin_Manage_Benefits_Click(object sender, EventArgs e)
        {
            // Utilities.Documents.Documents_Main disp2 = new Utilities.Documents.Documents_Main(base.ident);
            Applications.HR.HrBenefit.ListObjects List_Benefits = new Applications.HR.HrBenefit.ListObjects(base.ident, "Benefits", "61","Admin");
            List_Benefits.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Applications.HR.HrBenefit.HRAdmin.HRAdmin_Manage_Request review_req = new Applications.HR.HrBenefit.HRAdmin.HRAdmin_Manage_Request(base.ident);
            review_req.Show();
        }

        private void button_Charts_Click(object sender, EventArgs e)
        {
            new Infrastructure.Chart_Template(ident).Show();
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            new HR.HrBenefit.BenefitsReports_main(ident).Show();
        }
    }
}
