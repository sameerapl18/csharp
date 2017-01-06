namespace Applications.Applications.Sales.Sales_Products
{
    partial class Products_Main
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
            this.button_SalesQuotes = new System.Windows.Forms.Button();
            this.button_SalesOrders = new System.Windows.Forms.Button();
            this.button_CrystalReport = new System.Windows.Forms.Button();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.btn_Tableau = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SubName.Size = new System.Drawing.Size(176, 28);
            this.label_SubName.Text = "Sales of Products";
            // 
            // button_SalesQuotes
            // 
            this.button_SalesQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SalesQuotes.Location = new System.Drawing.Point(394, 260);
            this.button_SalesQuotes.Margin = new System.Windows.Forms.Padding(2);
            this.button_SalesQuotes.Name = "button_SalesQuotes";
            this.button_SalesQuotes.Size = new System.Drawing.Size(148, 74);
            this.button_SalesQuotes.TabIndex = 3;
            this.button_SalesQuotes.Text = "Sales Quotes";
            this.button_SalesQuotes.UseVisualStyleBackColor = true;
            this.button_SalesQuotes.Click += new System.EventHandler(this.button_SalesQuotes_Click);
            // 
            // button_SalesOrders
            // 
            this.button_SalesOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SalesOrders.Location = new System.Drawing.Point(643, 260);
            this.button_SalesOrders.Margin = new System.Windows.Forms.Padding(2);
            this.button_SalesOrders.Name = "button_SalesOrders";
            this.button_SalesOrders.Size = new System.Drawing.Size(148, 74);
            this.button_SalesOrders.TabIndex = 4;
            this.button_SalesOrders.Text = "Sales Orders";
            this.button_SalesOrders.UseVisualStyleBackColor = true;
            this.button_SalesOrders.Click += new System.EventHandler(this.button_SalesOrders_Click);
            // 
            // button_CrystalReport
            // 
            this.button_CrystalReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CrystalReport.Location = new System.Drawing.Point(761, 402);
            this.button_CrystalReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_CrystalReport.Name = "button_CrystalReport";
            this.button_CrystalReport.Size = new System.Drawing.Size(148, 74);
            this.button_CrystalReport.TabIndex = 5;
            this.button_CrystalReport.Text = "Crystal Report";
            this.button_CrystalReport.UseVisualStyleBackColor = true;
            this.button_CrystalReport.Click += new System.EventHandler(this.button_CrystalReport_Click);
            // 
            // btn_Chart
            // 
            this.btn_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chart.Location = new System.Drawing.Point(508, 402);
            this.btn_Chart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(148, 74);
            this.btn_Chart.TabIndex = 6;
            this.btn_Chart.Text = "Chart";
            this.btn_Chart.UseVisualStyleBackColor = true;
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // btn_Tableau
            // 
            this.btn_Tableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tableau.Location = new System.Drawing.Point(263, 402);
            this.btn_Tableau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tableau.Name = "btn_Tableau";
            this.btn_Tableau.Size = new System.Drawing.Size(148, 74);
            this.btn_Tableau.TabIndex = 7;
            this.btn_Tableau.Text = "Dashboard";
            this.btn_Tableau.UseVisualStyleBackColor = true;
            this.btn_Tableau.Click += new System.EventHandler(this.btn_Tableau_Click);
            // 
            // Products_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.btn_Tableau);
            this.Controls.Add(this.btn_Chart);
            this.Controls.Add(this.button_CrystalReport);
            this.Controls.Add(this.button_SalesOrders);
            this.Controls.Add(this.button_SalesQuotes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Products_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_SalesQuotes, 0);
            this.Controls.SetChildIndex(this.button_SalesOrders, 0);
            this.Controls.SetChildIndex(this.button_CrystalReport, 0);
            this.Controls.SetChildIndex(this.btn_Chart, 0);
            this.Controls.SetChildIndex(this.btn_Tableau, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SalesQuotes;
        private System.Windows.Forms.Button button_SalesOrders;
        private System.Windows.Forms.Button button_CrystalReport;
        private System.Windows.Forms.Button btn_Chart;
        private System.Windows.Forms.Button btn_Tableau;
    }
}
