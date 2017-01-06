namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class Accounting_Main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Main2));
            this.btn_Payments = new System.Windows.Forms.Button();
            this.btn_Invoices = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(195, 28);
            this.label_SubName.Text = "Acount Receivables";
            // 
            // btn_Payments
            // 
            this.btn_Payments.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Payments.Location = new System.Drawing.Point(826, 410);
            this.btn_Payments.Name = "btn_Payments";
            this.btn_Payments.Size = new System.Drawing.Size(151, 94);
            this.btn_Payments.TabIndex = 2;
            this.btn_Payments.Text = "Payments";
            this.btn_Payments.UseVisualStyleBackColor = false;
            this.btn_Payments.Click += new System.EventHandler(this.btn_Payments_Click);
            // 
            // btn_Invoices
            // 
            this.btn_Invoices.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Invoices.Location = new System.Drawing.Point(826, 554);
            this.btn_Invoices.Name = "btn_Invoices";
            this.btn_Invoices.Size = new System.Drawing.Size(151, 94);
            this.btn_Invoices.TabIndex = 3;
            this.btn_Invoices.Text = "Invoices";
            this.btn_Invoices.UseVisualStyleBackColor = false;
            this.btn_Invoices.Click += new System.EventHandler(this.btn_Invoices_Click);
            // 
            // Accounting_Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.btn_Invoices);
            this.Controls.Add(this.btn_Payments);
            this.Name = "Accounting_Main2";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.btn_Payments, 0);
            this.Controls.SetChildIndex(this.btn_Invoices, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Payments;
        private System.Windows.Forms.Button btn_Invoices;
    }
}
