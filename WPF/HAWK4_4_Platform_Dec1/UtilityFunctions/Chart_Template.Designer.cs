namespace Infrastructure
{
    partial class 
        Chart_Template
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.cboChartType = new System.Windows.Forms.ComboBox();
            this.cbo_Reports = new System.Windows.Forms.ComboBox();
            this.btn_generateChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_FilePath = new System.Windows.Forms.TextBox();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.btn_SelectChart = new System.Windows.Forms.Button();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RefreshData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.textBox_ReportTitle = new System.Windows.Forms.TextBox();
            this.label_SelectColor2 = new System.Windows.Forms.Label();
            this.label_SelectColor1 = new System.Windows.Forms.Label();
            this.textBox_ChartType = new System.Windows.Forms.TextBox();
            this.textBox_Var2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Var1 = new System.Windows.Forms.TextBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UserID
            // 
            this.label_UserID.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            // 
            // label_UserName
            // 
            this.label_UserName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            // 
            // label_SubName
            // 
            this.label_SubName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_SubName.Size = new System.Drawing.Size(268, 44);
            this.label_SubName.Text = "Charting Analysis";
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(307, 562);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 20;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 20;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1360, 483);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 5;
            // 
            // cboChartType
            // 
            this.cboChartType.FormattingEnabled = true;
            this.cboChartType.Location = new System.Drawing.Point(434, 465);
            this.cboChartType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChartType.Name = "cboChartType";
            this.cboChartType.Size = new System.Drawing.Size(176, 28);
            this.cboChartType.TabIndex = 4;
            this.cboChartType.Text = "Select Chart Type";
            this.cboChartType.SelectedIndexChanged += new System.EventHandler(this.cboChartType_SelectedIndexChanged);
            // 
            // cbo_Reports
            // 
            this.cbo_Reports.FormattingEnabled = true;
            this.cbo_Reports.Location = new System.Drawing.Point(435, 335);
            this.cbo_Reports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Reports.Name = "cbo_Reports";
            this.cbo_Reports.Size = new System.Drawing.Size(358, 28);
            this.cbo_Reports.TabIndex = 6;
            this.cbo_Reports.SelectedIndexChanged += new System.EventHandler(this.cbx_Reports_SelectedIndexChanged);
            // 
            // btn_generateChart
            // 
            this.btn_generateChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateChart.Location = new System.Drawing.Point(1154, 225);
            this.btn_generateChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generateChart.Name = "btn_generateChart";
            this.btn_generateChart.Size = new System.Drawing.Size(174, 91);
            this.btn_generateChart.TabIndex = 7;
            this.btn_generateChart.Text = "Display  Chart";
            this.btn_generateChart.UseVisualStyleBackColor = true;
            this.btn_generateChart.Click += new System.EventHandler(this.btn_generateChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Path";
            // 
            // txtBox_FilePath
            // 
            this.txtBox_FilePath.Location = new System.Drawing.Point(386, 242);
            this.txtBox_FilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_FilePath.Name = "txtBox_FilePath";
            this.txtBox_FilePath.Size = new System.Drawing.Size(320, 26);
            this.txtBox_FilePath.TabIndex = 9;
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseFile.Location = new System.Drawing.Point(734, 225);
            this.btn_BrowseFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(171, 91);
            this.btn_BrowseFile.TabIndex = 10;
            this.btn_BrowseFile.Text = "Browse for File";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // btn_SelectChart
            // 
            this.btn_SelectChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectChart.Location = new System.Drawing.Point(940, 225);
            this.btn_SelectChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SelectChart.Name = "btn_SelectChart";
            this.btn_SelectChart.Size = new System.Drawing.Size(174, 91);
            this.btn_SelectChart.TabIndex = 11;
            this.btn_SelectChart.Text = "Select Chart from List";
            this.btn_SelectChart.UseVisualStyleBackColor = true;
            this.btn_SelectChart.Click += new System.EventHandler(this.btn_SelectChart_Click);
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(415, 509);
            this.textBox_Data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Data.Multiline = true;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(1024, 103);
            this.textBox_Data.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chart Type";
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshData.Location = new System.Drawing.Point(1353, 225);
            this.btn_RefreshData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.Size = new System.Drawing.Size(174, 91);
            this.btn_RefreshData.TabIndex = 14;
            this.btn_RefreshData.Text = "   Refresh     Data";
            this.btn_RefreshData.UseVisualStyleBackColor = true;
            this.btn_RefreshData.Click += new System.EventHandler(this.btn_RefreshData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Query";
            // 
            // textBox_Query
            // 
            this.textBox_Query.Location = new System.Drawing.Point(940, 331);
            this.textBox_Query.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Query.Multiline = true;
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.Size = new System.Drawing.Size(828, 98);
            this.textBox_Query.TabIndex = 16;
            // 
            // textBox_ReportTitle
            // 
            this.textBox_ReportTitle.Location = new System.Drawing.Point(434, 391);
            this.textBox_ReportTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ReportTitle.Name = "textBox_ReportTitle";
            this.textBox_ReportTitle.Size = new System.Drawing.Size(360, 26);
            this.textBox_ReportTitle.TabIndex = 17;
            // 
            // label_SelectColor2
            // 
            this.label_SelectColor2.AutoSize = true;
            this.label_SelectColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectColor2.ForeColor = System.Drawing.Color.Red;
            this.label_SelectColor2.Location = new System.Drawing.Point(261, 337);
            this.label_SelectColor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SelectColor2.Name = "label_SelectColor2";
            this.label_SelectColor2.Size = new System.Drawing.Size(139, 25);
            this.label_SelectColor2.TabIndex = 22;
            this.label_SelectColor2.Text = "This List ==>";
            this.label_SelectColor2.Visible = false;
            // 
            // label_SelectColor1
            // 
            this.label_SelectColor1.AutoSize = true;
            this.label_SelectColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectColor1.ForeColor = System.Drawing.Color.Red;
            this.label_SelectColor1.Location = new System.Drawing.Point(266, 312);
            this.label_SelectColor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SelectColor1.Name = "label_SelectColor1";
            this.label_SelectColor1.Size = new System.Drawing.Size(121, 25);
            this.label_SelectColor1.TabIndex = 23;
            this.label_SelectColor1.Text = "Select from";
            this.label_SelectColor1.Visible = false;
            // 
            // textBox_ChartType
            // 
            this.textBox_ChartType.Location = new System.Drawing.Point(639, 466);
            this.textBox_ChartType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ChartType.Name = "textBox_ChartType";
            this.textBox_ChartType.Size = new System.Drawing.Size(139, 26);
            this.textBox_ChartType.TabIndex = 24;
            // 
            // textBox_Var2
            // 
            this.textBox_Var2.Location = new System.Drawing.Point(1245, 458);
            this.textBox_Var2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Var2.Name = "textBox_Var2";
            this.textBox_Var2.Size = new System.Drawing.Size(194, 26);
            this.textBox_Var2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1148, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Variable 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 468);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Variable 1";
            // 
            // textBox_Var1
            // 
            this.textBox_Var1.Location = new System.Drawing.Point(938, 460);
            this.textBox_Var1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Var1.Name = "textBox_Var1";
            this.textBox_Var1.Size = new System.Drawing.Size(194, 26);
            this.textBox_Var1.TabIndex = 20;
            // 
            // Chart_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1839, 1038);
            this.Controls.Add(this.textBox_ChartType);
            this.Controls.Add(this.label_SelectColor1);
            this.Controls.Add(this.label_SelectColor2);
            this.Controls.Add(this.textBox_Var2);
            this.Controls.Add(this.textBox_Var1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ReportTitle);
            this.Controls.Add(this.textBox_Query);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_RefreshData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.btn_SelectChart);
            this.Controls.Add(this.btn_BrowseFile);
            this.Controls.Add(this.txtBox_FilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generateChart);
            this.Controls.Add(this.cbo_Reports);
            this.Controls.Add(this.cboChartType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.Name = "Chart_Template";
            this.Controls.SetChildIndex(this.chart1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.cboChartType, 0);
            this.Controls.SetChildIndex(this.cbo_Reports, 0);
            this.Controls.SetChildIndex(this.btn_generateChart, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBox_FilePath, 0);
            this.Controls.SetChildIndex(this.btn_BrowseFile, 0);
            this.Controls.SetChildIndex(this.btn_SelectChart, 0);
            this.Controls.SetChildIndex(this.textBox_Data, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_RefreshData, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_Query, 0);
            this.Controls.SetChildIndex(this.textBox_ReportTitle, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox_Var1, 0);
            this.Controls.SetChildIndex(this.textBox_Var2, 0);
            this.Controls.SetChildIndex(this.label_SelectColor2, 0);
            this.Controls.SetChildIndex(this.label_SelectColor1, 0);
            this.Controls.SetChildIndex(this.textBox_ChartType, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.ComboBox cboChartType;
        protected System.Windows.Forms.Button btn_generateChart;
        public System.Windows.Forms.ComboBox cbo_Reports;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtBox_FilePath;
        protected System.Windows.Forms.Button btn_BrowseFile;
        protected System.Windows.Forms.Button btn_SelectChart;
        protected System.Windows.Forms.TextBox textBox_Data;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btn_RefreshData;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBox_Query;
        protected System.Windows.Forms.TextBox textBox_ReportTitle;
        protected System.Windows.Forms.Label label_SelectColor2;
        protected System.Windows.Forms.Label label_SelectColor1;
        protected System.Windows.Forms.TextBox textBox_ChartType;
        protected System.Windows.Forms.TextBox textBox_Var1;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox textBox_Var2;
    }
}
