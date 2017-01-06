﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Applications.Applications.Sales;

namespace Applications.Applications.Sales
{
    public partial class ListObjects : Utilities.Documents.ListObjects
    {
        public ListObjects()
        {
            InitializeComponent();
        }
        public ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public ListObjects(IdentityObject ident,int type)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            if(type == 0)//Sales Quotes
            {
                label_SubName.Text = "Sales Quotes";
                button_CreateSalesOrder.Visible = false;
                button_CreateSalesQuotes.Visible = true;
                //Display Sales Quotes in Process
                comboBox_TableName.Text = "ProcessDocs";
                DataTable dTable = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs where DocType = 29");
                dataGridView1.DataSource = dTable;
                textBox_CMD.Text = "Select * from ProcessDocs where DocType = 29";

            }
            else if(type == 1) //Sales Orders
            {
                label_SubName.Text = "Sales Orders";
                button_CreateSalesOrder.Visible = true;
                button_CreateSalesQuotes.Visible = false;
                //Display Sales Orders in Process
                comboBox_TableName.Text = "ProcessDocs";
                DataTable dTable = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs where DocType = 21");
                dataGridView1.DataSource = dTable;
                textBox_CMD.Text = "Select * from ProcessDocs where DocType = 21";
            }
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;

        }

        protected override void dataGridView1_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr,
                docNumStr).Show();
        }

        private void button_CreateSalesOrder_Click(object sender, EventArgs e)
        {
            int nextDocNum = Sales_Main.GetNextNumber("SalesOrders",0,"");
            CreateSalesOrder newSalesOrder = new CreateSalesOrder(base.ident, "SalesOrders", "21",nextDocNum.ToString());            
            newSalesOrder.Show();
        }

     
        private void ListObjects_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateSalesQuotes_Click(object sender, EventArgs e)
        {
            int nextDocNum = Sales_Main.GetNextNumber("SalesQuotes", 0, "");
            CreateSalesQuote newSalesQuote = new CreateSalesQuote(base.ident, "SalesQuotes", "29", nextDocNum.ToString());
            newSalesQuote.Show();
        }
    }
}
