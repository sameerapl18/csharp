using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Admin.ScheduleServiceOrder
{
    public partial class ScheduleServiceOrder : Utilities.Documents.ListObjects
    {
        public ScheduleServiceOrder()
        {
            InitializeComponent();
        }

         public ScheduleServiceOrder(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

         protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
             string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

             //new Applications.Operations.Admin.DisplaySpecificOrder.DisplaySpecificOrder(ident).Show();

             new Applications.Operations.Admin.DisplaySpecificOrder.DisplaySpecificOrder(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();

         }
    }
}
