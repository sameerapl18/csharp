namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class ReceivePayment
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
            this.btn_Transaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GetDoc
            // 
            this.button_GetDoc.Location = new System.Drawing.Point(755, 140);
            // 
            // button_ValidateData
            // 
            this.button_ValidateData.Location = new System.Drawing.Point(896, 140);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(896, 270);
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ResetCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetCommand.Location = new System.Drawing.Point(619, 183);
            this.button_ResetCommand.Size = new System.Drawing.Size(102, 45);
            this.button_ResetCommand.UseVisualStyleBackColor = false;
            // 
            // button_ResetLabels
            // 
            this.button_ResetLabels.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ResetLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetLabels.Size = new System.Drawing.Size(103, 46);
            this.button_ResetLabels.UseVisualStyleBackColor = false;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(896, 205);
            // 
            // button_Transaction
            // 
            this.button_Transaction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Transaction.Enabled = true;
            this.button_Transaction.Location = new System.Drawing.Point(896, 339);
            this.button_Transaction.Text = "Receive Payment";
            this.button_Transaction.UseVisualStyleBackColor = false;
            this.button_Transaction.Visible = true;
            this.button_Transaction.Click += new System.EventHandler(this.button_Transaction_Click);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(170, 28);
            this.label_SubName.Text = "Receive Payment";
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Transaction.Location = new System.Drawing.Point(896, 412);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(134, 72);
            this.btn_Transaction.TabIndex = 49;
            this.btn_Transaction.Text = "Create Accounting Transaction";
            this.btn_Transaction.UseVisualStyleBackColor = false;
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            // 
            // ReceivePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1101, 677);
            this.Controls.Add(this.btn_Transaction);
            this.Name = "ReceivePayment";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_GetDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button_Save, 0);
            this.Controls.SetChildIndex(this.button_Delete, 0);
            this.Controls.SetChildIndex(this.button_ValidateData, 0);
            this.Controls.SetChildIndex(this.listBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.button_ResetLabels, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button_Transaction, 0);
            this.Controls.SetChildIndex(this.btn_Transaction, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Transaction;
    }
}
