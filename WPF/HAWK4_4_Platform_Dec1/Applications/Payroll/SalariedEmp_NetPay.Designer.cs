namespace Applications.Applications.Payroll
{
    partial class NetPay_SalariedEmpl
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
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CMD.Size = new System.Drawing.Size(485, 31);
            this.textBox_CMD.Text = "select * from NetPay where DocType = 43 and Emp_ID=104";
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Margin = new System.Windows.Forms.Padding(2);
            // 
            // button_Display
            // 
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Margin = new System.Windows.Forms.Padding(2);
            // 
            // label_SubName
            // 
            this.label_SubName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SubName.Size = new System.Drawing.Size(90, 28);
            this.label_SubName.Text = "Net Pay";
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(159, 132);
            // 
            // NetPay_SalariedEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 482);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NetPay_SalariedEmpl";
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
