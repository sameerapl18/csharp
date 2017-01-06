using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class AccountsPayable_ReportingTemplate : HAWK_Template_2
    {
        public AccountsPayable_ReportingTemplate()
        {
            InitializeComponent();
        }

        public AccountsPayable_ReportingTemplate(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AccountsPayable_Template_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accounting.AccountsPayable.AcccountPayable_CrystalReport

           rept = new Accounting.AccountsPayable.AcccountPayable_CrystalReport();

            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();

            CR_Form.crystalReportViewer1.ReportSource = rept;

            CR_Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accounting.AccountsPayable.Supplier_Chart
           rept = new Accounting.AccountsPayable.Supplier_Chart();
            CrystalReport_Viewer SP_Form = new CrystalReport_Viewer();
            SP_Form.crystalReportViewer1.ReportSource = rept;
            SP_Form.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Accounting.AccountsPayable.AccountPayable_CrystalReport_monthly

          rept = new Accounting.AccountsPayable.AccountPayable_CrystalReport_monthly();

            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();

            CR_Form.crystalReportViewer1.ReportSource = rept;

            CR_Form.Show();
        }


    }
}
