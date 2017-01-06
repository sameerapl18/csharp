﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }


        public DisplaySelectedObject(IdentityObject ident)
        {
            this.components = null;
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }


        public DisplaySelectedObject(IdentityObject ident, string tableName, string docType, string docNum)
        {
            this.components = null;
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            base.textBox_DocNum.Text = docNum;
            base.textBox_DocType.Text = docType;
            base.textBox_TableName.Text = tableName;
            base.button_ResetCommand_Click(this, null);
            base.button_Display_Click(this, null);
        }


        


        private void btnDisplayFormatted_Click(object sender, EventArgs e)
        {
            new FormattedDataDisplay(base.ident, base.textBox_TableName.Text, base.textBox_DocType.Text, base.textBox_DocNum.Text).Show();
        }



    }
}
