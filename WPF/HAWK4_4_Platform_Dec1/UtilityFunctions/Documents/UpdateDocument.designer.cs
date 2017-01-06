namespace Utilities.Documents
{
    partial class UpdateDocument

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Command = new System.Windows.Forms.TextBox();
            this.button_ExeCommand = new System.Windows.Forms.Button();
            this.textBox_CommandIndx = new System.Windows.Forms.TextBox();
            this.dataGridView_0 = new System.Windows.Forms.DataGridView();
            this.dataGridView_1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_2 = new System.Windows.Forms.DataGridView();
            this.dataGridView_3 = new System.Windows.Forms.DataGridView();
            this.comboBox_Commands = new System.Windows.Forms.ComboBox();
            this.textBox_Response = new System.Windows.Forms.TextBox();
            this.dataGridView_4 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.button_Next_Cmd = new System.Windows.Forms.Button();
            this.button_RetrieveCommands = new System.Windows.Forms.Button();
            this.textBox_ScriptName = new System.Windows.Forms.TextBox();
            this.checkBox_Pause = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Table1Totals = new System.Windows.Forms.TextBox();
            this.textBox_Table2Totals = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Table3Totals = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Table4Totals = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Table5Totals = new System.Windows.Forms.TextBox();
            this.textBox_Sum6 = new System.Windows.Forms.TextBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(1193, 810);
            this.textBox_CMD.Size = new System.Drawing.Size(10, 10);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Text = "Update_AccPayables";
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Items.AddRange(new object[] {
            "AccPayables",
            "AccountsReceivable",
            "Inventory",
            " "});
            this.comboBox_TableName.Text = "   select table to update";
            this.comboBox_TableName.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1179, 822);
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.Text = ".";
            // 
            // button_Display
            // 
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(1087, 200);
            this.button_Display.Size = new System.Drawing.Size(80, 45);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(1195, 839);
            this.button_Reset.Size = new System.Drawing.Size(10, 10);
            // 
            // label_SubName
            // 
            this.label_SubName.Location = new System.Drawing.Point(437, 75);
            this.label_SubName.Size = new System.Drawing.Size(276, 28);
            this.label_SubName.Text = " Update Account Document";
            // 
            // textBox_Command
            // 
            this.textBox_Command.Location = new System.Drawing.Point(690, 157);
            this.textBox_Command.Multiline = true;
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(428, 31);
            this.textBox_Command.TabIndex = 19;
            // 
            // button_ExeCommand
            // 
            this.button_ExeCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExeCommand.Location = new System.Drawing.Point(954, 198);
            this.button_ExeCommand.Name = "button_ExeCommand";
            this.button_ExeCommand.Size = new System.Drawing.Size(102, 53);
            this.button_ExeCommand.TabIndex = 20;
            this.button_ExeCommand.Text = "Execute Command";
            this.button_ExeCommand.UseVisualStyleBackColor = true;
            this.button_ExeCommand.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // textBox_CommandIndx
            // 
            this.textBox_CommandIndx.Location = new System.Drawing.Point(649, 165);
            this.textBox_CommandIndx.Name = "textBox_CommandIndx";
            this.textBox_CommandIndx.Size = new System.Drawing.Size(28, 20);
            this.textBox_CommandIndx.TabIndex = 21;
            // 
            // dataGridView_0
            // 
            this.dataGridView_0.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_0.Location = new System.Drawing.Point(212, 279);
            this.dataGridView_0.Name = "dataGridView_0";
            this.dataGridView_0.Size = new System.Drawing.Size(1061, 181);
            this.dataGridView_0.TabIndex = 22;
            // 
            // dataGridView_1
            // 
            this.dataGridView_1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_1.Location = new System.Drawing.Point(1237, 822);
            this.dataGridView_1.Name = "dataGridView_1";
            this.dataGridView_1.Size = new System.Drawing.Size(10, 13);
            this.dataGridView_1.TabIndex = 23;
            // 
            // dataGridView_2
            // 
            this.dataGridView_2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_2.Location = new System.Drawing.Point(204, 472);
            this.dataGridView_2.Name = "dataGridView_2";
            this.dataGridView_2.Size = new System.Drawing.Size(1069, 126);
            this.dataGridView_2.TabIndex = 24;
            // 
            // dataGridView_3
            // 
            this.dataGridView_3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_3.Location = new System.Drawing.Point(204, 604);
            this.dataGridView_3.Name = "dataGridView_3";
            this.dataGridView_3.Size = new System.Drawing.Size(1069, 120);
            this.dataGridView_3.TabIndex = 25;
            // 
            // comboBox_Commands
            // 
            this.comboBox_Commands.FormattingEnabled = true;
            this.comboBox_Commands.Location = new System.Drawing.Point(214, 255);
            this.comboBox_Commands.Name = "comboBox_Commands";
            this.comboBox_Commands.Size = new System.Drawing.Size(462, 21);
            this.comboBox_Commands.TabIndex = 26;
            this.comboBox_Commands.SelectedIndexChanged += new System.EventHandler(this.comboBox_Commands_SelectedIndexChanged);
            // 
            // textBox_Response
            // 
            this.textBox_Response.Location = new System.Drawing.Point(886, 255);
            this.textBox_Response.Name = "textBox_Response";
            this.textBox_Response.Size = new System.Drawing.Size(167, 20);
            this.textBox_Response.TabIndex = 27;
            // 
            // dataGridView_4
            // 
            this.dataGridView_4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_4.Location = new System.Drawing.Point(213, 762);
            this.dataGridView_4.Name = "dataGridView_4";
            this.dataGridView_4.Size = new System.Drawing.Size(1054, 166);
            this.dataGridView_4.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Account";
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(763, 256);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(86, 20);
            this.textBox_Account.TabIndex = 32;
            // 
            // button_Next_Cmd
            // 
            this.button_Next_Cmd.Location = new System.Drawing.Point(829, 199);
            this.button_Next_Cmd.Name = "button_Next_Cmd";
            this.button_Next_Cmd.Size = new System.Drawing.Size(100, 50);
            this.button_Next_Cmd.TabIndex = 33;
            this.button_Next_Cmd.Text = "Next Command";
            this.button_Next_Cmd.UseVisualStyleBackColor = true;
            this.button_Next_Cmd.Click += new System.EventHandler(this.button_Next_Cmd_Click);
            // 
            // button_RetrieveCommands
            // 
            this.button_RetrieveCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RetrieveCommands.Location = new System.Drawing.Point(690, 200);
            this.button_RetrieveCommands.Name = "button_RetrieveCommands";
            this.button_RetrieveCommands.Size = new System.Drawing.Size(121, 49);
            this.button_RetrieveCommands.TabIndex = 34;
            this.button_RetrieveCommands.Text = "Retrieve Commands";
            this.button_RetrieveCommands.UseVisualStyleBackColor = true;
            this.button_RetrieveCommands.Click += new System.EventHandler(this.button_RetrieveCommands_Click);
            // 
            // textBox_ScriptName
            // 
            this.textBox_ScriptName.Location = new System.Drawing.Point(1074, 253);
            this.textBox_ScriptName.Name = "textBox_ScriptName";
            this.textBox_ScriptName.Size = new System.Drawing.Size(193, 20);
            this.textBox_ScriptName.TabIndex = 35;
            this.textBox_ScriptName.Text = "Acc_Receivable";
            // 
            // checkBox_Pause
            // 
            this.checkBox_Pause.AutoSize = true;
            this.checkBox_Pause.Location = new System.Drawing.Point(1140, 160);
            this.checkBox_Pause.Name = "checkBox_Pause";
            this.checkBox_Pause.Size = new System.Drawing.Size(130, 17);
            this.checkBox_Pause.TabIndex = 36;
            this.checkBox_Pause.Text = "Pause between Steps";
            this.checkBox_Pause.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sum of Old values";
            // 
            // textBox_Table1Totals
            // 
            this.textBox_Table1Totals.Location = new System.Drawing.Point(374, 735);
            this.textBox_Table1Totals.Name = "textBox_Table1Totals";
            this.textBox_Table1Totals.Size = new System.Drawing.Size(104, 20);
            this.textBox_Table1Totals.TabIndex = 38;
            // 
            // textBox_Table2Totals
            // 
            this.textBox_Table2Totals.Location = new System.Drawing.Point(531, 735);
            this.textBox_Table2Totals.Name = "textBox_Table2Totals";
            this.textBox_Table2Totals.Size = new System.Drawing.Size(104, 20);
            this.textBox_Table2Totals.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 741);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = " + ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 731);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = " - ";
            // 
            // textBox_Table3Totals
            // 
            this.textBox_Table3Totals.Location = new System.Drawing.Point(684, 735);
            this.textBox_Table3Totals.Name = "textBox_Table3Totals";
            this.textBox_Table3Totals.Size = new System.Drawing.Size(100, 20);
            this.textBox_Table3Totals.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(804, 736);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = " = ";
            // 
            // textBox_Table4Totals
            // 
            this.textBox_Table4Totals.Location = new System.Drawing.Point(860, 737);
            this.textBox_Table4Totals.Name = "textBox_Table4Totals";
            this.textBox_Table4Totals.Size = new System.Drawing.Size(100, 20);
            this.textBox_Table4Totals.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(990, 735);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = " < ? >";
            // 
            // textBox_Table5Totals
            // 
            this.textBox_Table5Totals.Location = new System.Drawing.Point(1067, 735);
            this.textBox_Table5Totals.Name = "textBox_Table5Totals";
            this.textBox_Table5Totals.Size = new System.Drawing.Size(100, 20);
            this.textBox_Table5Totals.TabIndex = 46;
            // 
            // textBox_Sum6
            // 
            this.textBox_Sum6.Location = new System.Drawing.Point(1195, 733);
            this.textBox_Sum6.Name = "textBox_Sum6";
            this.textBox_Sum6.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sum6.TabIndex = 47;
            // 
            // UpdateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1306, 873);
            this.Controls.Add(this.dataGridView_0);
            this.Controls.Add(this.textBox_Sum6);
            this.Controls.Add(this.textBox_Table5Totals);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Table4Totals);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Table3Totals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Table2Totals);
            this.Controls.Add(this.textBox_Table1Totals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_Pause);
            this.Controls.Add(this.textBox_ScriptName);
            this.Controls.Add(this.button_RetrieveCommands);
            this.Controls.Add(this.button_Next_Cmd);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_4);
            this.Controls.Add(this.textBox_Response);
            this.Controls.Add(this.comboBox_Commands);
            this.Controls.Add(this.dataGridView_3);
            this.Controls.Add(this.dataGridView_2);
            this.Controls.Add(this.dataGridView_1);
            this.Controls.Add(this.textBox_CommandIndx);
            this.Controls.Add(this.button_ExeCommand);
            this.Controls.Add(this.textBox_Command);
            this.Name = "UpdateDocument";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.label_3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox_ExternalRef, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.textBox_InternalRef, 0);
            this.Controls.SetChildIndex(this.button_Reset, 0);
            this.Controls.SetChildIndex(this.textBox_Command, 0);
            this.Controls.SetChildIndex(this.button_ExeCommand, 0);
            this.Controls.SetChildIndex(this.textBox_CommandIndx, 0);
            this.Controls.SetChildIndex(this.dataGridView_1, 0);
            this.Controls.SetChildIndex(this.dataGridView_2, 0);
            this.Controls.SetChildIndex(this.dataGridView_3, 0);
            this.Controls.SetChildIndex(this.comboBox_Commands, 0);
            this.Controls.SetChildIndex(this.textBox_Response, 0);
            this.Controls.SetChildIndex(this.dataGridView_4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox_Account, 0);
            this.Controls.SetChildIndex(this.button_Next_Cmd, 0);
            this.Controls.SetChildIndex(this.button_RetrieveCommands, 0);
            this.Controls.SetChildIndex(this.textBox_ScriptName, 0);
            this.Controls.SetChildIndex(this.checkBox_Pause, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_Table1Totals, 0);
            this.Controls.SetChildIndex(this.textBox_Table2Totals, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox_Table3Totals, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox_Table4Totals, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox_Table5Totals, 0);
            this.Controls.SetChildIndex(this.textBox_Sum6, 0);
            this.Controls.SetChildIndex(this.dataGridView_0, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label_description;
        protected System.Windows.Forms.Button button_RawData;
        protected System.Windows.Forms.Button button_ResetCommand;
        protected System.Windows.Forms.Button button_DisplayDoc;
        protected System.Windows.Forms.DataGridView dataGridView2;
        protected System.Windows.Forms.TextBox textBox_Description;
       // protected System.Windows.Forms.TextBox textBox_Cmd;
        protected System.Windows.Forms.TextBox textBox_DataStrings;
        protected System.Windows.Forms.TextBox textBox_DocNum;
        protected System.Windows.Forms.TextBox textBox_DocType;
        protected System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.DataGridView dataGridView0;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.TextBox textBox_CmdIndex;
        private System.Windows.Forms.TextBox textBox_Command;
        private System.Windows.Forms.Button button_ExeCommand;
        private System.Windows.Forms.TextBox textBox_CommandIndx;
        private System.Windows.Forms.DataGridView dataGridView_0;
        private System.Windows.Forms.DataGridView dataGridView_1;
        private System.Windows.Forms.DataGridView dataGridView_2;
        private System.Windows.Forms.DataGridView dataGridView_3;
        private System.Windows.Forms.ComboBox comboBox_Commands;
        private System.Windows.Forms.TextBox textBox_Response;
        private System.Windows.Forms.DataGridView dataGridView_4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.Button button_Next_Cmd;
        private System.Windows.Forms.Button button_RetrieveCommands;
        private System.Windows.Forms.TextBox textBox_ScriptName;
        private System.Windows.Forms.CheckBox checkBox_Pause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Table1Totals;
        private System.Windows.Forms.TextBox textBox_Table2Totals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Table3Totals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Table4Totals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Table5Totals;
        private System.Windows.Forms.TextBox textBox_Sum6;
        //protected System.Windows.Forms.Label label2;
        //protected System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Est_Value;
    }
}
