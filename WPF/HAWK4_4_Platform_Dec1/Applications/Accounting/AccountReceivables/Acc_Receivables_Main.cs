using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class Acc_Receivables_Main : Applications.Accounting.AccountReceivables.Acc_Receivable_Template
    {

       
        public Acc_Receivables_Main()
        {
            this.components = null;
            InitializeComponent();
            base.Close();
        }


        public Acc_Receivables_Main(IdentityObject ident)
       {
        
        this.InitializeComponent();
        base.SaveIdent(ident);
        base.DisplayIdent(ident);
        
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            Accounting.AccountReceivables.ListObjects lstObj = new AccountReceivables.ListObjects();
            lstObj.Show();
        }

        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            base.Close();
            Accounting.AccountReceivables.DisplaySelectedObject displayObj = new DisplaySelectedObject();
            displayObj.Show();
        }

        private void btn_Documents_Click(object sender, EventArgs e)
        {
            new Applications.Accounting.AccountReceivables.List_AccReceivables(ident).Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
       
            AccountReceivables.CrystalReport_AccReceivables cr = new AccountReceivables.CrystalReport_AccReceivables();

            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = cr;
            CR_Form.Show();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            new Utilities.Documents.UpdateDocument(ident, "AccountsReceivable", "53", " ").Show();
        }
    
    }
}
