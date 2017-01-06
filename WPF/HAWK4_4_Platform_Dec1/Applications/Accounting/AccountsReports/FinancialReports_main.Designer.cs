namespace Applications.Applications.Accounting.AccountsReports
{
    partial class financialReports_main
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
            this.balanceSheetcrys = new System.Windows.Forms.Button();
            this.crysIncomeRpt = new System.Windows.Forms.Button();
            this.crysTrialBalrpt = new System.Windows.Forms.Button();
            this.newIntBalance = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceSheetcrys
            // 
            this.balanceSheetcrys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceSheetcrys.Location = new System.Drawing.Point(382, 199);
            this.balanceSheetcrys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.balanceSheetcrys.Name = "balanceSheetcrys";
            this.balanceSheetcrys.Size = new System.Drawing.Size(118, 68);
            this.balanceSheetcrys.TabIndex = 2;
            this.balanceSheetcrys.Text = "Balance  Sheet";
            this.balanceSheetcrys.UseVisualStyleBackColor = true;
            this.balanceSheetcrys.Click += new System.EventHandler(this.balanceSheetcrys_Click);
            // 
            // crysIncomeRpt
            // 
            this.crysIncomeRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crysIncomeRpt.Location = new System.Drawing.Point(582, 198);
            this.crysIncomeRpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crysIncomeRpt.Name = "crysIncomeRpt";
            this.crysIncomeRpt.Size = new System.Drawing.Size(115, 69);
            this.crysIncomeRpt.TabIndex = 3;
            this.crysIncomeRpt.Text = "Income Statement";
            this.crysIncomeRpt.UseVisualStyleBackColor = true;
            this.crysIncomeRpt.Click += new System.EventHandler(this.crysIncomeRpt_Click);
            // 
            // crysTrialBalrpt
            // 
            this.crysTrialBalrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crysTrialBalrpt.Location = new System.Drawing.Point(382, 331);
            this.crysTrialBalrpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crysTrialBalrpt.Name = "crysTrialBalrpt";
            this.crysTrialBalrpt.Size = new System.Drawing.Size(118, 71);
            this.crysTrialBalrpt.TabIndex = 5;
            this.crysTrialBalrpt.Text = " Trial   Balance";
            this.crysTrialBalrpt.UseVisualStyleBackColor = true;
            this.crysTrialBalrpt.Click += new System.EventHandler(this.crysTrialBalrpt_Click);
            // 
            // newIntBalance
            // 
            this.newIntBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIntBalance.Location = new System.Drawing.Point(582, 331);
            this.newIntBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newIntBalance.Name = "newIntBalance";
            this.newIntBalance.Size = new System.Drawing.Size(118, 71);
            this.newIntBalance.TabIndex = 6;
            this.newIntBalance.Text = "Alternate Trial Balance";
            this.newIntBalance.UseVisualStyleBackColor = true;
            this.newIntBalance.Click += new System.EventHandler(this.newIntBalance_Click);
            // 
            // financialReports_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.newIntBalance);
            this.Controls.Add(this.crysTrialBalrpt);
            this.Controls.Add(this.crysIncomeRpt);
            this.Controls.Add(this.balanceSheetcrys);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "financialReports_main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.balanceSheetcrys, 0);
            this.Controls.SetChildIndex(this.crysIncomeRpt, 0);
            this.Controls.SetChildIndex(this.crysTrialBalrpt, 0);
            this.Controls.SetChildIndex(this.newIntBalance, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balanceSheetcrys;
        private System.Windows.Forms.Button crysIncomeRpt;
        private System.Windows.Forms.Button crysTrialBalrpt;
        private System.Windows.Forms.Button newIntBalance;
    }
}
