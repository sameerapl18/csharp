using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class Accounting_Main2 : Applications.Accounting.AccountReceivables.Acc_Receivable_Template
    {
        public Accounting_Main2()
        {
            this.components = null;
            InitializeComponent();
            base.Close();
        }


        public Accounting_Main2(IdentityObject ident)
        {

            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
         
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            new Applications.Accounting.AccountReceivables.List_Receivabledocs(ident).Show();
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            new Applications.Accounting.AccountReceivables.List_Invoices(ident).Show();
        }
    }
}
