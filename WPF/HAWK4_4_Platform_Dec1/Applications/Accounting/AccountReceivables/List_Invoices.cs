using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class List_Invoices : Applications.Accounting.AccountReceivables.ListObjects
    {
        public List_Invoices()
        {
            InitializeComponent();
        }

        public List_Invoices(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            base.DisplayIdent(identObject);

            if (comboBox1.SelectedText.ToString() == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please select the status and check for the items in that particular status";
               
            }
            else
            {
                lbl_message.Visible = false;
               
                DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = dtable;
                dataGridView1.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "Select..")
            {
                lbl_message.Visible = false;
                lbl_message.Text = "";
                textBox_CMD.Text = "Select * from ProcessDocs Where status = " + comboBox1.SelectedItem + "and DocType = 58" ;
                DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = dtable;
            }
            else
            {
                lbl_message.Visible = false;
                lbl_message.Text = "";
                base.textBox_CMD.Text = "select * from processDocs where DocType = 58";
                DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = dtable;
            }
        }


        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            new InvoiceDisplay(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();

        }

        
    }
}
