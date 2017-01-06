namespace Applications.Applications.Payroll
{
    partial class UpdateTime
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
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmitTime = new System.Windows.Forms.Button();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblWeekId = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(279, 189);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(28, 13);
            this.lblEmp.TabIndex = 2;
            this.lblEmp.Text = "Emp";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(279, 226);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(36, 13);
            this.lblWeek.TabIndex = 3;
            this.lblWeek.Text = "Week";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(444, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnSubmitTime
            // 
            this.btnSubmitTime.Location = new System.Drawing.Point(482, 372);
            this.btnSubmitTime.Name = "btnSubmitTime";
            this.btnSubmitTime.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTime.TabIndex = 7;
            this.btnSubmitTime.Text = "Submit";
            this.btnSubmitTime.UseVisualStyleBackColor = true;
            this.btnSubmitTime.Click += new System.EventHandler(this.btnSubmitTime_Click);
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(196, 188);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(42, 13);
            this.lblEmpId.TabIndex = 8;
            this.lblEmpId.Text = "Emp ID";
            // 
            // lblWeekId
            // 
            this.lblWeekId.AutoSize = true;
            this.lblWeekId.Location = new System.Drawing.Point(196, 226);
            this.lblWeekId.Name = "lblWeekId";
            this.lblWeekId.Size = new System.Drawing.Size(50, 13);
            this.lblWeekId.TabIndex = 9;
            this.lblWeekId.Text = "Week ID";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(191, 259);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(191, 297);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(282, 258);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(61, 13);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "Start Week";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(282, 296);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(58, 13);
            this.lblEnd.TabIndex = 13;
            this.lblEnd.Text = "End Week";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(491, 422);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 14;
            // 
            // UpdateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblWeekId);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.btnSubmitTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblEmp);
            this.Name = "UpdateTime";
            this.Text = "UpdateTime";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.lblEmp, 0);
            this.Controls.SetChildIndex(this.lblWeek, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnSubmitTime, 0);
            this.Controls.SetChildIndex(this.lblEmpId, 0);
            this.Controls.SetChildIndex(this.lblWeekId, 0);
            this.Controls.SetChildIndex(this.lblStartDate, 0);
            this.Controls.SetChildIndex(this.lblEndDate, 0);
            this.Controls.SetChildIndex(this.lblStart, 0);
            this.Controls.SetChildIndex(this.lblEnd, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmitTime;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblWeekId;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblResult;
    }
}