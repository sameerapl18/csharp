﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Skills
{
    public partial class Skills_ListObjects : Utilities.Documents.ListObjects
    {
        public Skills_ListObjects()
        {
            InitializeComponent();
        }
        public Skills_ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            loadTable();
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;
        }
        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            new Skills_DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();
        }
        private void loadTable()
        {
            comboBox_TableName.Items.Clear();
            comboBox_TableName.Items.Add("Skills");
        }

        private void btnShowSkillForm_Click(object sender, EventArgs e)
        {
            new NewSkill(ident, getNextDocNum()).Show();
        }
        private string getNextDocNum()
        {
            return (int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString()) + 1).ToString();
        }
    }
}
