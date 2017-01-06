namespace Applications.Applications.HR.HrBenefit
{
    partial class BenefitsReports_main
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
            this.AllEmpReport = new System.Windows.Forms.Button();
            this.CompensationComparison = new System.Windows.Forms.Button();
            this.BenefitsRequestedMax = new System.Windows.Forms.Button();
            this.CrystalReport1 = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(197, 28);
            this.label_SubName.Text = " Benefits Reporting";
            // 
            // AllEmpReport
            // 
            this.AllEmpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllEmpReport.Location = new System.Drawing.Point(382, 199);
            this.AllEmpReport.Margin = new System.Windows.Forms.Padding(2);
            this.AllEmpReport.Name = "AllEmpReport";
            this.AllEmpReport.Size = new System.Drawing.Size(118, 68);
            this.AllEmpReport.TabIndex = 2;
            this.AllEmpReport.Text = "All Employees Report";
            this.AllEmpReport.UseVisualStyleBackColor = true;
            this.AllEmpReport.Click += new System.EventHandler(this.AllEmpReport_Click);
            // 
            // CompensationComparison
            // 
            this.CompensationComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompensationComparison.Location = new System.Drawing.Point(582, 198);
            this.CompensationComparison.Margin = new System.Windows.Forms.Padding(2);
            this.CompensationComparison.Name = "CompensationComparison";
            this.CompensationComparison.Size = new System.Drawing.Size(118, 69);
            this.CompensationComparison.TabIndex = 3;
            this.CompensationComparison.Text = "Compensation Comparison";
            this.CompensationComparison.UseVisualStyleBackColor = true;
            this.CompensationComparison.Click += new System.EventHandler(this.CompensationComparison_Click);
            // 
            // BenefitsRequestedMax
            // 
            this.BenefitsRequestedMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenefitsRequestedMax.Location = new System.Drawing.Point(382, 331);
            this.BenefitsRequestedMax.Margin = new System.Windows.Forms.Padding(2);
            this.BenefitsRequestedMax.Name = "BenefitsRequestedMax";
            this.BenefitsRequestedMax.Size = new System.Drawing.Size(118, 71);
            this.BenefitsRequestedMax.TabIndex = 5;
            this.BenefitsRequestedMax.Text = "Benefits Request Count";
            this.BenefitsRequestedMax.UseVisualStyleBackColor = true;
            this.BenefitsRequestedMax.Click += new System.EventHandler(this.BenefitsRequestedMax_Click);
            // 
            // CrystalReport1
            // 
            this.CrystalReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystalReport1.Location = new System.Drawing.Point(582, 331);
            this.CrystalReport1.Margin = new System.Windows.Forms.Padding(2);
            this.CrystalReport1.Name = "CrystalReport1";
            this.CrystalReport1.Size = new System.Drawing.Size(118, 71);
            this.CrystalReport1.TabIndex = 6;
            this.CrystalReport1.Text = "Hourly and Full Time Report";
            this.CrystalReport1.UseVisualStyleBackColor = true;
            this.CrystalReport1.Click += new System.EventHandler(this.CrystalReport1_Click);
            // 
            // BenefitsReports_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.CrystalReport1);
            this.Controls.Add(this.BenefitsRequestedMax);
            this.Controls.Add(this.CompensationComparison);
            this.Controls.Add(this.AllEmpReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BenefitsReports_main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.AllEmpReport, 0);
            this.Controls.SetChildIndex(this.CompensationComparison, 0);
            this.Controls.SetChildIndex(this.BenefitsRequestedMax, 0);
            this.Controls.SetChildIndex(this.CrystalReport1, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllEmpReport;
        private System.Windows.Forms.Button CompensationComparison;
        private System.Windows.Forms.Button BenefitsRequestedMax;
        private System.Windows.Forms.Button CrystalReport1;
    }
}
