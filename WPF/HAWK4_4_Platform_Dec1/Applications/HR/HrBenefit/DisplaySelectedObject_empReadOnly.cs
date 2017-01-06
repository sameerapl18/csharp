using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class DisplaySelectedObject_empReadOnly : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject_empReadOnly()
        {
            InitializeComponent();
        }
        public DisplaySelectedObject_empReadOnly(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }
        public DisplaySelectedObject_empReadOnly(IdentityObject ident, string tableName, string docType, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;
          
            button_ResetCommand_Click(this, null);

        }
    }
}
