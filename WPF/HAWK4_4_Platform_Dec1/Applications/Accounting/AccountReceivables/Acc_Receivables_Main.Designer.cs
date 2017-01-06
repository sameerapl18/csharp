namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class Acc_Receivables_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acc_Receivables_Main));
            this.btn_Documents = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_List
            // 
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_DisplaySelected
            // 
            this.button_DisplaySelected.Click += new System.EventHandler(this.button_DisplaySelected_Click);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(210, 28);
            this.label_SubName.Text = " Account Receivables";
            // 
            // btn_Documents
            // 
            this.btn_Documents.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Documents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Documents.Location = new System.Drawing.Point(952, 256);
            this.btn_Documents.Name = "btn_Documents";
            this.btn_Documents.Size = new System.Drawing.Size(181, 104);
            this.btn_Documents.TabIndex = 2;
            this.btn_Documents.Text = "Documents";
            this.btn_Documents.UseVisualStyleBackColor = false;
            this.btn_Documents.Click += new System.EventHandler(this.btn_Documents_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Reports.Location = new System.Drawing.Point(952, 411);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(181, 104);
            this.btn_Reports.TabIndex = 3;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.UseVisualStyleBackColor = false;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_Update.Location = new System.Drawing.Point(952, 567);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(181, 104);
            this.button_Update.TabIndex = 4;
            this.button_Update.Text = "Update Accounts Receivable";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Acc_Receivables_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_Documents);
            this.Name = "Acc_Receivables_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.btn_Documents, 0);
            this.Controls.SetChildIndex(this.btn_Reports, 0);
            this.Controls.SetChildIndex(this.button_Update, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Documents;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button button_Update;
    }
}
