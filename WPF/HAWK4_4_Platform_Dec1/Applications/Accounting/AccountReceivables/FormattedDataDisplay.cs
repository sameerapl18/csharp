﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class FormattedDataDisplay : HAWK_Template_3
    {
        public FormattedDataDisplay()
        {
            InitializeComponent();
        }


        public FormattedDataDisplay(IdentityObject _ident)
        {
            this.components = null;
            InitializeComponent();
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        public FormattedDataDisplay(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            //textBox_DataStrings.Visible = false;
            
            dataGridView2.Visible = false;
            
            textBox_DocNum.Text = _docNum;
            textBox_ExternalRef.Text  = _docType ;
            textBox_TableName.Text = _tableName ;
            textBox_CMD.Text = "select * from " + _tableName ;
           // LoadBBasicDocInfo();
            button_ResetCommand_Click(this, null);
        
        }

        private void button_RawData_Click(object sender, EventArgs e)
        {
            textbox_DataStrings.Visible = !textbox_DataStrings.Visible;
        }
        private void button_Display_Click(object sender, EventArgs e)
        {


            List<string> _records = Utilities.DataBaseUtility.GetList(textBox_CMD.Text);
            DataTable table = new DataTable();
            if (_records.Count < 2)
            {
                MessageBox.Show(" didn't find records for " + textBox_CMD.Text);
                return;
            }
            else
            {
                _records.RemoveAt(0);
                List<string> list2 = Utilities.DataBaseUtility.GetList("Select * from customers WHERE DocNum = " + _records[0].Split(new char[] { ',' })[2]);
                if (list2.Count >= 2)
                {
                    table = Utilities.DataBaseUtility.GetTable("Select * from {this.textBox_TableName.Text}_Details WHERE DocNum = {this.textBox_DocNum.Text} and DocType = {this.textBox_DocType.Text}");
                    pnlCustomerDetails.Visible = true;
                    Utilities.Customer customer = new Utilities.Customer(list2[1]);
                    this.label_OrderNumber.Text = "Document Number";
                    this.label_CustomerNum.Text = customer.EntityID.ToString();
                    this.label_SupplierName.Text = customer.Name + " " + customer.Name2;
                    this.label_SupplierAddr.Text = customer.Address;
                    this.label_SupplierAddress2.Text = customer.AddressFull;
                    this.label_SupplierPhone.Text = customer.Phone;
                    this.label_ShipName.Text = "Metro, Video & Photo";
                    this.label_ShippingAddr2.Text = "2422 Bay Area Blvd";
                    this.label_ShipAddress.Text = "Houston, TX, 77058";
                    this.label_SupplierEmail.Text = customer.Email;
                    this.label_OrderNum.Text = this.textBox_DocNum.Text;
                    this.label_DateValue.Text = DateTime.Now.ToShortDateString();
                    
                    LoadDetailRecords(textBox_TableName.Text, textBox_DocNum.Text, textBox_ExternalRef.Text);
                }
            }
        }
            

        protected /*override*/ void button_ResetCommand_Click(object sender, EventArgs e)
        {
            string _docType = textBox_ExternalRef.Text.Trim();
            string _docNum = textBox_DocNum.Text.Trim();
            string part1 = " select * from  " + textBox_TableName.Text; ;
            string part2 = "";
            string part3 = "";

            if ((_docType != "*") && (_docType != " ") && (_docType != ""))
                part2 = " where DocType = " + _docType;
            if ((_docNum != "*") && (_docNum != " ") && (_docNum != ""))
            {
                if (part2 == "")
                    part3 = " where DocNum = " + _docNum;
                else part3 = " and DocNum = " + _docNum;
            }
            string cmdStr = part1 + part2 + part3;
            textBox_CMD.Text = cmdStr;

        }

        protected /*override*/  void LoadBBasicDocInfo()
        {
            string cmd = " select * from  " + textBox_TableName.Text;
            List<string> _documentValues = Utilities.DataBaseUtility.GetList(cmd);
            for (int i = 1; i < _documentValues.Count; i++)
            {
                string[] fields = _documentValues[i].Split(',');
                comboBox1.Items.Add(fields[0] + " , " + fields[10]);
            }
        }



        protected void LoadDetailRecords(string tablename, string docNumber, string docType)
        {
            string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                                             textBox_TableName.Text.Trim(), docNumber, docType);
            //try
            //{
            List<string> _records = Utilities.DataBaseUtility.GetList(cmdStr2);
            for (int i = 1; i < _records.Count; i++)
                textbox_DataStrings.Text += "\r\n" + _records[i];
            if (_records.Count < 2)
            {
                dataGridView2.Visible = false;
                return;
            }
            dataGridView2.Visible = true;
            DataTable dTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
            dataGridView2.Rows.Clear();                                 //DataSource = _documentTable;
            //  dataGridView2.Rows.Add();
            //  int current = dataGridView2.Rows.Count;
            int last = dTable.Rows.Count;
            double valueSum = 0;
            for (int i = 0; i < last; i++)
            {
                dataGridView2.Rows.Add();
                if (dTable.Rows[i].ItemArray.Length > 7)
                    dataGridView2.Rows[i].Cells[0].Value = dTable.Rows[i][7];
                double quant = Double.Parse((dTable.Rows[i][5]).ToString());
                dataGridView2.Rows[i].Cells[1].Value = String.Format("{0,12:F2}", quant);
                double rate = Double.Parse((dTable.Rows[i][6]).ToString());
                dataGridView2.Rows[i].Cells[2].Value = String.Format("{0,12:F2}", rate);
                dataGridView2.Rows[i].Cells[3].Value = String.Format("{0,14:F2}", quant * rate);
                valueSum += quant * rate;
            }
            dataGridView2.Rows.Add("", "", "", "===========");
            dataGridView2.Rows.Add("", "", "", String.Format("{0,14:C}", valueSum));
            dataGridView2.Visible = true;
            
            //    panel1.Visible = true;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("  error in reading Gross pay record " + ex.Message);
            //}
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = textBox_TableName.Text;
            string docTypeStr = textBox_ExternalRef.Text;
            string index1 = e.ToString();
            string newtableName = textBox_TableName.Text + "_Details";
            //   DisplayDetailObject dispObj = new DisplayDetailObject(base.ident, newtableName, docTypeStr, docNumStr, index1); dispObj.Show();
        }
    }
}
