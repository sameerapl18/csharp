using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class UpdateDocument :  HAWK_Template_3
    {
        string cmdStr;  // = comboBox_TableName.SelectedItem.ToString();
        string[] fields;  // = CmdStr.Split(' ');
        int cmdIndx, source, dest;
        List<string> datalist;  // = Utilities.DataBaseUtility.GetList(newCmdStr);
        DataTable dtable1, dtable2, dtable3, dtable4;       // = Utilities.DataBaseUtility.GetTable(newCmdStr);
        Double sum1, sum2, sum3, sum4, sum5, sum6;              
        public UpdateDocument()
        {
            InitializeComponent();
            textBox_Command.Text   = "Select * from Update_AccPayables";
            textBox_CommandIndx.Text  = "1";
            textBox_TableName.Text = "AccPayables";
            textBox_ScriptName.Text = "Update_AccPayables";
            LoadBBasicDocInfo();
        }
        public UpdateDocument(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
        //    textBox_DataStrings.Visible = false;
        //    dataGridView1.Visible = false;
        //    dataGridView2.Visible = false;
        //    textBox_DocNum.Text = _docNum;
        //    textBox_DocType.Text  = _docType ;
        //    textBox_TableName.Text = comboBox_TableName.SelectedItem.ToString();
            textBox_TableName.Text = _tableName;
            textBox_Command.Text = "select * from " + _tableName;
            textBox_ScriptName.Text = "Update_" + textBox_TableName.Text;
            LoadUpdateCommands();

           // LoadBBasicDocInfo();
       //     button_ResetCommand_Click(this, null);
        
        }
           protected /*override*/  void LoadBBasicDocInfo()
           {
            //   string cmd = " select * from  " + textBox_TableName.Text;
              //  _documentValues =
               string filepath = "App_Data/" + textBox_ScriptName.Text + ".txt";
               List<string> _list = new List<string>();
               comboBox_Commands.Items.Clear();
               try
               {
                   System.IO.FileStream infile = new System.IO.FileStream(filepath, System.IO.FileMode.Open);
                   System.IO.StreamReader reader = new System.IO.StreamReader(infile);
                   string inputstr = reader.ReadLine();
                   while (inputstr != null)
                   {
                       _list.Add(inputstr);
                       comboBox_Commands.Items.Add (inputstr);
                       inputstr = reader.ReadLine();
                   }
                   reader.Close();
               }
               catch (Exception ex) { MessageBox.Show(ex.Message); }

               comboBox_Commands.SelectedIndex = 0;
           }
        protected void LoadDetailRecords(string tablename, string docNumber, string docType)
        {
            string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                                             textBox_TableName.Text.Trim(), docNumber, docType);
            //try
            //{
                List<string> _records = Utilities.DataBaseUtility.GetList(cmdStr2 );
                for (int i = 1; i < _records.Count; i++)
                    textBox_DataStrings.Text += "\r\n" + _records[i];
                if (_records.Count < 2)
                {
                    dataGridView2.Visible = false;
                    return;
                }
                dataGridView2.Visible = true;
                DataTable dTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView2.Rows.Clear();                                 //DataSource = _documentTable;
                dataGridView2.Visible = true;
              
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("  error in reading Gross pay record " + ex.Message);
            //}
        }
        protected /*override*/ void button_ResetCommand_Click(object sender, EventArgs e)
        {
        //    string _docType = textBox_DocType.Text.Trim();
        //    string _docNum = textBox_DocNum.Text.Trim();
            string part1 = " select * from  " + textBox_TableName.Text; ;
            string part2 = "";
            string part3 = "";

            //if ((_docType != "*") && (_docType != " ") && (_docType != ""))
            //    part2 = " where DocType = " + _docType;
            //if ((_docNum != "*") && (_docNum != " ") && (_docNum != ""))
            //{
            //    if (part2 == "")
            //        part3 = " where DocNum = " + _docNum;
            //    else part3 = " and DocNum = " + _docNum;
            //}
            string cmdStr = part1 + part2 + part3;
            textBox_Command.Text = cmdStr;

        }

        protected void button_DisplayDoc_Click(object sender, EventArgs e)
        {
            //try
            //{
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                List<string> _records = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
                if (_records.Count < 2)
                {
                    MessageBox.Show(" didn't find records for " + textBox_Command.Text);
                    return;
                }
            //    LoadDetailRecords(textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("  error in reading GenDocs " + ex.Message);
            //}    

        }

        private void button_RawData_Click(object sender, EventArgs e)
        {
            textBox_DataStrings.Visible = !textBox_DataStrings.Visible;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = textBox_DocNum.Text;
            string docTypeStr = textBox_DocType.Text;
            string index1 = e.RowIndex.ToString();
            string newtableName = textBox_TableName.Text + "_Details";
         //   DisplayDetailObject dispObj = new DisplayDetailObject(base.ident, newtableName, docTypeStr, docNumStr, index1); dispObj.Show();
   
        }

        private void comboBox_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_TableName.Text = comboBox_TableName.SelectedItem.ToString();
            textBox_ScriptName.Text =  "Update_" + textBox_TableName.Text; 
            LoadUpdateCommands();
        }
        protected virtual void LoadUpdateCommands()
        {   //   Download a table of queries
            string cmd = "select * from " + textBox_ScriptName.Text;
            List<string> queryList = Utilities.DataBaseUtility.GetList(cmd);
            int numReturned = queryList.Count - 1;
            comboBox_Commands.Items.Clear();
          //  comboBox3.Items.Add("  Acc_Payable_Update");
            for (int i = 1; i < numReturned; i++)
            {
               string[] fields = queryList[i].Split(',');
                comboBox_Commands.Items.Add(fields[1]);

            }
        }
        private void button_Display_Click(object sender, EventArgs e)
        {
            List<string> _records = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
            if (_records.Count < 2)
            {
                MessageBox.Show(" didn't find records for " + textBox_Command.Text);
                return;
            }
           // LoadDetailRecords(textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
               dataGridView1.DataSource = dtable1;
        }

        private void button_Execute_Click(object sender, EventArgs e)
        {
            string cmdStr = Compress(textBox_Command.Text);
            string oldValueStr; Double oldValue;
            int match1, match2, match3, match4;
             fields = cmdStr.Split(' ');
            string cmdObject = fields[0].Trim();
            switch (cmdObject)
            {
                case "End":
                case "end":
                    { return; }

                case "Pause":
                case "pause":
                    { return; }

                case "select":
                case "Select":
                    {
                        int fromIndx = cmdStr.IndexOf("from");
                        string newCmdStr = "select * from " + cmdStr.Substring(fromIndx + 4);
                        datalist = Utilities.DataBaseUtility.GetList(newCmdStr);
                        textBox_Response.Text = (datalist.Count - 1).ToString() + "  records were read";
                        switch (fields[1].Trim())
                        {
                                case "data1":
                                case "DataGrid0":
                                case "DataGrid1":
                                    {
                                   // datalist = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
                                    dtable1 = Utilities.DataBaseUtility.GetTable(newCmdStr );
                                    dataGridView_0.DataSource = dtable1;
                               
                                    break;
                                }
                                case "data2":
                                case "DataGrid2":
                                {
                                    dtable2 = Utilities.DataBaseUtility.GetTable(newCmdStr);
                                    dataGridView_2.DataSource = dtable2;
                                    break;
                                }
                                case "data3":
                                case "DataGrid3":
                                {
                                     dtable3 = Utilities.DataBaseUtility.GetTable(newCmdStr);
                                     dataGridView_3.DataSource = dtable3;
                                    break;
                                }
                        }
                        break;
                    }     //  end of case "select"

                case "display":
                case "Display":
                {
                    switch (fields[1].Trim())
                    {
                        case "data1":
                        case "DataGrid1":
                        {
                            //    datalist = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
                            //    dtable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
                                dataGridView_0.DataSource = dtable1;
                                break;
                        }
                        case "data2":
                        case "DataGrid2":
                        {
                                dataGridView_2.DataSource = dtable2;
                                break;
                        }
                        case "data3":
                        case "dataGrid3":
                        {
                            dataGridView_3.DataSource = dtable3;
                            break;
                        }
                        case "data4":
                        case "dataGrid4":
                        {
                            dataGridView_1.DataSource = dtable4;
                            break;
                        }
                    }
                    break;
                }     //  end of case "select"

                case "copy":
                case "Copy":
                    //  copy data1 all columns  to data4 
                    {  
                        if (fields[2].Trim() == "all")
                        {
                          //  dtable4 = new DataTable("dtable1"); 
                               dtable4 = Utilities.DataBaseUtility.GetTable("select * from  " + textBox_TableName.Text);
                            dataGridView_4.DataSource = dtable4;
                            return;
                        }
                        //  copy data1 column 10 to data4 column 6 when data1 column 6 equals data4 column 5
                        //  copy current date str to data4 column 6 when data1 column 6 equals data4 column 5
                        //   0     1      2    3  4    5     6    7  8     9     10  11   12    13     14   15
                        if (fields[2].Trim() == "column")
                             source = Int32.Parse(fields[3]);
                       // else{ MessageBox.Show("problem with field 2 of  " + textBox_Command.Text );
                        if (fields[1].Trim() == "current")
                            source = 3;
                        }

                        if (fields[6].Trim() == "column")
                            dest = Int32.Parse(fields[7]);
                        else { MessageBox.Show("problem with field 6 of  " + textBox_Command.Text); return; }

                        if (fields.Length < 9)
                        {
                            int last = dtable1.Rows.Count - 1;
                            for (int i = 0; i <= last; i++)
                            {
                               // if (fields[1].Trim() == "current")
                               // { dtable4.Rows[i][dest] = DateTime.Now.ToShortDateString(); }
                               // else
                               {
                                   source = Int32.Parse(fields[3]);
                                   oldValueStr = dtable4.Rows[i][source].ToString();
                                    dtable4.Rows[i][dest] = oldValueStr;
                                    dataGridView_4.Rows[i].Cells[dest].Value = oldValueStr;
                                }
                            } return;
                        }  //  end of method for fields.Length < 8
                        else
                        {
                            
                            //  copy data2 column  9 to data4 column 6 when data1 column 6 equals data2 column 5
                            //  copy current date str to data4 column 6 when data1 column 6 equals data3 column 5
                            //   0     1      2    3  4    5     6    7  8     9     10  11   12    13     14   15
                            if (fields[10].Trim() == "column")
                                match1 = Int32.Parse(fields[11]);
                            else { MessageBox.Show("problem with field 10 of  " + textBox_Command.Text); return; }

                            if (fields[14].Trim() == "column")
                            {
                                match2 = Int32.Parse(fields[15]);
                                match3 = Int32.Parse(fields[15]);
                            }
                            else { MessageBox.Show("problem with field 14 of  " + textBox_Command.Text); return; }
                            int lastTemp = dtable2.Rows.Count - 1;
                            if (fields[1].Trim() == "data3")
                            {
                                lastTemp = dtable3.Rows.Count - 1;
                                match3 = Int32.Parse(fields[15]);
                            }
                       
                            int lastMain = dtable1.Rows.Count - 1;
                            for (int i = 0; i <= lastMain; i++)
                            {
                                for (int j = 0; j <= lastTemp; j++)
                                {
                                    string mainID = dtable1.Rows[i][match1].ToString().Trim();
                                    string tempID = dtable2.Rows[j][match2].ToString().Trim();
                                    if (fields[13].Trim() == "data3") tempID = dtable3.Rows[j][match3].ToString().Trim();
                                    if (mainID == tempID)
                                    {
                                        if (fields[1].Trim() == "current")
                                        { dtable4.Rows[i][dest] = DateTime.Now.ToShortDateString(); }
                                        else
                                        {
                                          //  oldValueStr = dtable1.Rows[i][dest].ToString();
                                          //  oldValue = Double.Parse(oldValueStr);
                                            string updateStr = dtable2.Rows[j][source].ToString();
                                            if (fields[1].Trim() == "data3") 
                                                updateStr = dtable3.Rows[j][source].ToString().Trim();
                                            double updateValue = Double.Parse(updateStr);
                                            dtable4.Rows[i][dest] = updateValue;
                                            //   dataGridView_4.Rows[i].Cells[dest].Value = updateStr;
                                        }  //  end of else clause
                                    }  //  end of if ststement
                                }      //  end of for statement 
                            }
                    } break;
                //  end of case "update"
                case "add":
                case "Add":
                    {
                        //  add  data2 column  5 to data4 column 9 when data2 column 3 equals data4 column 3
                        //   0     1      2    3  4    5    6    7   8    9     10   11  12     13    14   15 
                        if (fields[2].Trim() == "column")
                            source = Int32.Parse(fields[3]);
                        else { MessageBox.Show("problem with field 2 of  " + textBox_Command.Text); return; }

                        if (fields[6].Trim() == "column")
                            dest = Int32.Parse(fields[7]);
                        else { MessageBox.Show("problem with field 6 of  " + textBox_Command.Text); return; }

                        if (fields[10].Trim() == "column")
                            match2 = Int32.Parse(fields[11]);
                        else { MessageBox.Show("problem with field 10 of  " + textBox_Command.Text); return; }

                        if (fields[14].Trim() == "column")
                            match4 = Int32.Parse(fields[15]);
                        else { MessageBox.Show("problem with field 10 of  " + textBox_Command.Text); return; }

                        int lastMain = dtable4.Rows.Count - 1;
                        for (int i = 0; i <= lastMain; i++)
                        {
                            int lastTemp = dtable2.Rows.Count - 1;
                            for (int j = 0; j <= lastTemp; j++)
                            {
                                string mainID = dtable2.Rows[j][match2].ToString().Trim();
                                string tempID = dtable4.Rows[i][match4].ToString().Trim();
                                if (mainID == tempID)
                                {
                                     oldValueStr = dtable4.Rows[i][dest].ToString();
                                    string updateStr = dtable2.Rows[j][source].ToString();
                                    double updateValue = Double.Parse(updateStr);
                                     oldValue = Double.Parse(oldValueStr);
                                    sum2 += updateValue;
                                    dtable4.Rows[i][dest] = oldValue + updateValue;
                                    sum4 += updateValue;
                                  //  dtable4.Rows[i][5] = updateValue;
                                  //  dtable4.Rows[i][6] = DateTime.Now.ToShortDateString();
                                }  //  else continue;
                            }
                        }

                    } break;
                //  end of case "add"
                case "subtract":
                case "Subtract":
                    {
                        // subtract  data2 column  5 from data4 column 9 when data2 column 3 equals data4 column 3
                        //   0         1      2    3   4     5    6    7   8    9     10   11  12     13    14   15 
                        if (fields[2].Trim() == "column")
                            source = Int32.Parse(fields[3]);
                        else { MessageBox.Show("problem with field 2 of  " + textBox_Command.Text); return; }

                        if (fields[6].Trim() == "column")
                            dest = Int32.Parse(fields[7]);
                        else { MessageBox.Show("problem with field 6 of  " + textBox_Command.Text); return; }

                        if (fields[10].Trim() == "column")
                            match3 = Int32.Parse(fields[11]);
                        else { MessageBox.Show("problem with field 10 of  " + textBox_Command.Text); return; }

                        if (fields[14].Trim() == "column")
                            match4 = Int32.Parse(fields[15]);
                        else { MessageBox.Show("problem with field 10 of  " + textBox_Command.Text); return; }

                        int lastMain = dtable4.Rows.Count - 1;
                        for (int i = 0; i <= lastMain; i++)
                        {
                            int lastTemp = dtable3.Rows.Count - 1;
                            for (int j = 0; j <= lastTemp; j++)
                            {
                                string mainID = dtable3.Rows[j][match3].ToString().Trim();
                                string tempID = dtable4.Rows[i][match4].ToString().Trim();
                                if (mainID == tempID)
                                {
                                  //  double oldValue = (Double)dtable4.Rows[i][dest];
                                    oldValueStr = dtable4.Rows[i][dest].ToString();
                                    string updateStr = dtable3.Rows[j][source].ToString();
                                    double updateValue = Double.Parse(updateStr);
                                     oldValue = Double.Parse(oldValueStr);
                                    sum3 += updateValue;
                                    sum4 -= updateValue;
                                    dtable4.Rows[i][dest] = oldValue - updateValue;
                                 //   dtable4.Rows[i][8] =  updateValue;
                                 //   dtable4.Rows[i][7] = DateTime.Now.ToShortDateString();
                                }  //  else continue;
                            }
                        }

                    } break;
                //  end of case "subtract"
                case "archive":
                case "Archive":
                {

                   // if (cmdStr.IndexOf("with") != -1)
                   // {

                    //    string query = " create table " + fields[1] + new System.DateTime().ToString("yyyy_MM_dd_hh_mm_ss") + " as ( select * from " + fields[1] + " );";
                    //    Utilities.DataBaseUtility.Execute(base.ident, query);
                        
                    //}
                     if (cmdStr.IndexOf("from") != -1)
                    {
                        //string query = " create table " + textBox_TableName.Text + new System.DateTime().ToString("yyyy_MM_dd_hh_mm_ss") + " as ( select * from " + textBox_TableName.Text + " where 1=2 );";
                        //Utilities.DataBaseUtility.Execute(base.ident, query);
                        //foreach (DataRow row in dtable4.Rows)
                        //{
                        //    string q = " insert into " + textBox_TableName.Text + "values ( ";

                        //    foreach (DataColumn column in dtable4.Columns)
                        //        q += "'" + row[column] + "',";
                        //    int index = q.LastIndexOf(',');

                        //    q = q.Remove(index,1)+ ")";

                        //    Utilities.DataBaseUtility.Execute(base.ident, q);
                        //}
                        int numberOfColumns = dtable4.Columns.Count;
                         foreach(DataRow row in dtable4.Rows)
                         {

                             var q =  "Select * from " + fields[1].Trim() + " where docnum = " + row[0] ;

                             var data = Utilities.DataBaseUtility.GetTable(q);
                             if (data == null)
                             {

                                 //if not insert it
                                 q = " insert into " + fields[1].Trim() + " values ( ";

                                 foreach (DataColumn column in dtable4.Columns)
                                     q += "'" + row[column] + "',";

                                 int index = q.LastIndexOf(',');
                                 q = q.Remove(index, 1) + ")";
                             }
                             else
                             {

                                 //if not insert it
                                 q = " update " +  fields[1].Trim() + " set ";

                                 foreach (DataColumn column in dtable4.Columns)
                                     q += column + " = '" + row[column] +"',";

                                 int index = q.LastIndexOf(',');
                                 q = q.Remove(index, 1) + " where docnum = " + row[0];
                             }

                             Utilities.DataBaseUtility.Execute(base.ident, q);                             
                         }
                    }
                } break;


                case "update":
                case "Update":
                    {
                        DataTable table = fields[7].Trim().IndexOf("2") != -1 ? dtable2 : dtable3;
                        table = fields[7].Trim().IndexOf("4") != -1 ? dtable4 : table;
                        foreach (DataRow row in table.Rows)
                        {
                            string docNum1 = row[0].ToString();
                            string query = "update " + fields[1].Trim() + " set " + fields[4] + " = " + fields[5] + " where DocNum = " + docNum1 + ";" ;
                            Utilities.DataBaseUtility.Execute(base.ident, query);
                        }

                        //   MessageBox.Show(" time to update !");

                    } break;
                //  end of case "update"

                case "remove":
                case "Remove":
                    {
                        string query = " delete from " + fields[5].Trim() + " where " + fields[1].Trim() + " = " + fields[2].Trim() + ";";
                        Utilities.DataBaseUtility.Execute(base.ident, query);
                    } break;
                case "verify":
                case "Verify":
                case "check":
                {  //  verify   data4 column 9 using data1 column 9 + data2 column 6 - data3 column 6
                   //     0       1     2    3   4     5      6   7 8  9      10  11 12  13    14   15  
                    if (fields[2].Trim() == "column")
                            dest = Int32.Parse(fields[3]);
                        else { MessageBox.Show("problem with field 2 of  " + textBox_Command.Text); return; }

                    int lastRow = dtable4.Rows.Count - 1;
                    sum1 = 0;
                    sum6 = 0;
                    for (int i = 0; i <= lastRow; i++)
                    {
                        string cellStr = dtable1.Rows[i][dest].ToString();
                        sum1 += Double.Parse(cellStr);
                        cellStr = dtable4.Rows[i][dest].ToString();
                        sum6 += Double.Parse(cellStr);
                    }
                    textBox_Table1Totals.Text = sum1.ToString();
                    textBox_Table2Totals.Text = sum2.ToString();
                    textBox_Table3Totals.Text = sum3.ToString();
                    textBox_Table5Totals.Text = (sum4 + sum1).ToString();
                    textBox_Table4Totals.Text = (sum1 + sum2 - sum3).ToString();
                     textBox_Sum6.Text = sum6.ToString();
                    dataGridView_4.DataSource = dtable4;
                }
                //  end of case "update"
                break;
            }
            if (comboBox_Commands.SelectedIndex < comboBox_Commands.Items.Count - 1) // comboBox_Commands.SelectedIndex++;
                button_Next_Cmd_Click(this, null);
        }



        //protected virtual string Compress(string targetStr)
        //{    // (1) Download a table of queries
            //  string cleanString = targetStr.Substring(2).Trim();
            //  char[] array_C = new char[] (cleanString);
            //  while (cleanString.IndexOf("  ") > -1)
            //    cleanString.Replace("  ", "^");
            //
            //   for (int i = 2; i < targetStr.Length; i++)
            //            {
            //                string lastChar = targetStr[i];
            //
            //                int indx = targetStr.Trim().IndexOf(" ", 2);
            //                StringBuilder builder = new StringBuilder();
            //                builder.Append(targetStr.Substring(2, indx).Trim());
            //                int startindx = indx + 1;
            //                indx = targetStr.Trim().IndexOf(" ", startindx);
            //                builder.Append(" " + targetStr.Substring(startindx, indx).Trim());
            //            }
            //
            //     return cleanString.Trim();
            // }
        protected virtual string Compress(string targetStr)
        {
            //   removes adjacent blanks from a string and returns a “clean” string

            string cleanString = string.Join(" ", targetStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            return cleanString.Trim();
        }

        private void comboBox_Commands_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Command.Text = comboBox_Commands.SelectedItem.ToString().Substring(2);
        }

        private void button_Next_Cmd_Click(object sender, EventArgs e)
        {
            if (comboBox_Commands.SelectedIndex < comboBox_Commands.Items.Count - 1)    comboBox_Commands.SelectedIndex++;
            if (!checkBox_Pause.Checked) button_Execute_Click(this, null);
        }

        private void button_RetrieveCommands_Click(object sender, EventArgs e)
        {
            LoadBBasicDocInfo();
        }        
   }
    
}
