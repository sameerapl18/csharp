using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class BenefitsReports_main : HAWK_Template_2 
    {
        public BenefitsReports_main()
        {
            InitializeComponent();
        }
        public BenefitsReports_main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void AllEmpReport_Click(object sender, EventArgs e)
        {
            HR.HrBenefit.AllEmpBenefits  rept = new HR.HrBenefit.AllEmpBenefits ();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void CompensationComparison_Click(object sender, EventArgs e)
        {
            HR.HrBenefit.Benefits_Compensation_Comparison rept = new HR.HrBenefit.Benefits_Compensation_Comparison();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void BenefitsRequestedMax_Click(object sender, EventArgs e)
        {
            HR.HrBenefit.Benefit_requested_max_times rept = new HR.HrBenefit.Benefit_requested_max_times();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void crysInternalrpt_Click(object sender, EventArgs e)
        {
            HR.HrBenefit.CrystalReport1 rept = new HR.HrBenefit.CrystalReport1();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void CrystalReport1_Click(object sender, EventArgs e)
        {
            HR.HrBenefit.Hourly_and_Fulltime_employee  rept = new HR.HrBenefit.Hourly_and_Fulltime_employee ();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }
    }
}
