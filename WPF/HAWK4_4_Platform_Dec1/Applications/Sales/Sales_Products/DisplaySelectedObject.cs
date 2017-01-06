using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Applications.Applications.Sales
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }
        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        public DisplaySelectedObject(IdentityObject ident, string tableName, string docType, string docNum)
        {
            
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;
            button_ResetCommand_Click(this, null);

            //string sqlPosted = String.Format("Select DocNum from ProcessDocs where DocNum = {0} and DocType = {1}", docNum, docType);
            //List<string> mPosted = Utilities.DataBaseUtility.GetList(sqlPosted, ',');

          
            if (!(tableName == "SalesQuotes" | tableName == "SalesOrders"))
            {
                return;
            }

            button_ChangeDoc.Visible = false;

            if (docType == "29")
            {
                label_SubName.Text = "Sales Quote";
                string sqlPosted = String.Format("Select DocNum from ProcessDocs where DocType = 29 and DocNum =(Select DocRef from SalesQuotes where DocNum = {0})", docNum);
                List<string> mPosted = Utilities.DataBaseUtility.GetList(sqlPosted, ',');
                
                if (mPosted.Count > 1)//Already posted
                {
                    button_PostSalesOrder.Visible = false;
                    //Check to see if it is converted to Sales Orders yet
                    string sqlConverted = String.Format("Select DocNum from ProcessDocs where DocType = 21 and DocNum = (Select DocRef from SalesQuotes where DocNum = {0})", docNum);
                    List<string> mConverted = Utilities.DataBaseUtility.GetList(sqlConverted, ',');
                    if(mConverted.Count < 2)//Not converted yet
                    {
                        button1.Visible = true;
                    }
                }
                else //not posted yet
                {
                    button_PostSalesOrder.Visible = true;
                    button_ChangeDoc.Visible = true;
                }
        
            }

            if (docType == "21")
            {
                label_SubName.Text = "Sales Orders";
                string sqlPosted = String.Format("Select DocNum from ProcessDocs where DocType = 21 and DocNum =(Select DocRef from SalesOrders where DocNum = {0})", docNum);
                List<string> mPosted = Utilities.DataBaseUtility.GetList(sqlPosted, ',');

                if (mPosted.Count > 1)//Already posted
                {
                    button_PostSalesOrder.Visible = false;
                }
                else//not posted yet
                {
                    button_PostSalesOrder.Visible = true;
                    button_ChangeDoc.Visible = true;
                }

            }

        }

        private void button_ChangeDoc_Click(object sender, EventArgs e)
        {
                      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Take the next sales order
            int nextDocNum = Sales_Main.GetNextNumber("SalesOrders", 0, "");
            int extRef = Convert.ToInt32(textBox_ExtAgent.Text);
            int intRef = Convert.ToInt32(textBox_IntAgent.Text);
            int processID = Convert.ToInt32(textBox_ProcessID.Text);

            double numValue1 = Convert.ToDouble(textBox_NumValue1.Text);
            double numValue2 = Convert.ToDouble(textBox_NumValue2.Text);
            // insert header into sales order

             string sql = String.Format("insert into SalesOrders values ( {0}, 21, {1}, {2}, 2, {3}, '{4}','{5}',{6},{7},'{8}')",
                nextDocNum, //0
              extRef, intRef, //1,2
               processID, //3
                textBox_TextValue1.Text, textBox_TextValue2.Text, //4,5
                numValue1, numValue2,//6,7
                textBox_Comment.Text);//8
            string update = Utilities.DataBaseUtility.Execute(sql, ident);


            //insert into ProcessDocs
            string commentProcessDocs = "Sales Order for customer " + textBox_ExtAgent.Text;
            string sqlProcessDocs = String.Format("insert into ProcessDocs values ({0}, {1}, {2},{3}, {4}, {5},'{6}','{7}',{8},{9},'{10}')",
          processID, "21", extRef, intRef,
             textBox_Status.Text, nextDocNum, textBox_TextValue1.Text, textBox_TextValue2.Text,
             numValue1, numValue2, commentProcessDocs);
            string updateProcessDocs = Utilities.DataBaseUtility.Execute(sqlProcessDocs, ident);

            //insert details into sales order detail
            //Select sales quotes line
            DataTable quoteLines = new DataTable();
            string cmd = String.Format("Select * from SalesQuotes_Details where DocNum = {0} and DocType = {1}", textBox_DocNum.Text, textBox_DocType.Text);
            quoteLines = Utilities.DataBaseUtility.GetTable(cmd);           

            foreach (DataRow row in quoteLines.Rows)
            {
                string materialID = row[2].ToString();
                string index2 = row[3].ToString();
                string listPrice = row[4].ToString();
                string quantity = row[5].ToString();
                string price = row[6].ToString();
                string comment = row[7].ToString();

                sql = String.Format("insert into SalesOrders_Details values ({0}, 21, {1}, {2}, {3}, {4},{5},'{6}')", 
                    nextDocNum,
                    materialID,
                    index2, listPrice, quantity, price, comment);
                update = Utilities.DataBaseUtility.Execute(sql, ident);
                                       

               string sqlProcessDocDetails = String.Format("insert into ProcessDocs_Details values ({0}, {1}, {2},{3}, {4}, {5},'{6}','{7}')",
           processID, "21", materialID, textBox_Status.Text,
           nextDocNum, quantity, price, commentProcessDocs);
               update = Utilities.DataBaseUtility.Execute(sqlProcessDocDetails, ident);
            }

          
            //

                MessageBox.Show("Converted and posted successfully! Your Sales Order number is " + nextDocNum);
                button1.Visible = false;

            //load display form

        }

        private void button_DisplayDoc_Click(object sender, EventArgs e)
        {

        }

        private void button_PostSalesOrder_Click(object sender, EventArgs e)//Should be named button_Post (used for both Post Sales Orders and Post Sales Quotes)
        {
            int nextDocNum = Sales_Main.GetNextNumber("ProcessDocs", 0, "");
            string commentProcessDocs = "Sales " + (textBox_DocType.Text.Trim() == "21" ? "Orders " : "Quotes ") + " for customer " + textBox_ExtAgent.Text;
            string sql = String.Format("insert into ProcessDocs values ({0}, {1}, {2},{3}, {4}, {5},'{6}','{7}',{8},{9},'{10}')",
              nextDocNum, textBox_DocType.Text, textBox_ExtAgent.Text, textBox_IntAgent.Text,
              textBox_Status.Text, textBox_DocNum.Text, textBox_TextValue1.Text, textBox_TextValue2.Text,
              textBox_NumValue1.Text, textBox_NumValue2.Text, commentProcessDocs);

            string update = Utilities.DataBaseUtility.Execute(sql, ident);

            sql = "Update Sales" + (textBox_DocType.Text.Trim() == "21" ? "Orders" : "Quotes") + " set DocRef = " + nextDocNum + " where DocNum = " + textBox_DocNum.Text + " and DocType = " + textBox_DocType.Text;
             update = Utilities.DataBaseUtility.Execute(sql, ident);

            DataTable quoteLines = new DataTable();
            string cmd = String.Format("Select * from Sales" + (textBox_DocType.Text.Trim() == "21" ? "Orders" : "Quotes") + "_Details where DocNum = {0} and DocType = {1}", textBox_DocNum.Text, textBox_DocType.Text);
            quoteLines = Utilities.DataBaseUtility.GetTable(cmd);

            foreach (DataRow row in quoteLines.Rows)
            {
                string materialID = row[2].ToString();
                string index2 = row[3].ToString();
                string listPrice = row[4].ToString();
                string quantity = row[5].ToString();
                string price = row[6].ToString();
                string comment = row[7].ToString();

                sql = String.Format("insert into ProcessDocs_Details values ({0}, {1}, {2},{3}, {4}, {5},'{6}','{7}')",
           nextDocNum, textBox_DocType.Text, materialID, textBox_Status.Text,
            textBox_DocNum.Text, quantity, price, commentProcessDocs);
                update = Utilities.DataBaseUtility.Execute(sql, ident);

                
            }
            if(update =="no errors")
            {
                update = "Posted successfully";
            }
            MessageBox.Show(update);
            button_PostSalesOrder.Visible = false;
            if(textBox_DocType.Text.Trim() == "29")
            {
                button1.Visible = true;
            }

            button_ChangeDoc.Visible = false;
        }

      
    }

}
