using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Infrastructure
{
    public partial class Chart_Template : HAWK_Template_2
    {

        private string chartTitle;
        string filepath;
        List<String> queryList;
        string bigString;
        string[] chartObjectStrings;
        int chartIndex;
        ChartObject chartObj;

        public Chart_Template()
        {
            InitializeComponent();
            LoadChartTypes();
            Control.CheckForIllegalCrossThreadCalls = false;
            btn_BrowseFile_Click(this, null);
            btn_SelectChart_Click(this, null);
        }


        public Chart_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            LoadChartTypes();
            Control.CheckForIllegalCrossThreadCalls = false;
            btn_BrowseFile_Click(this, null);
            btn_SelectChart_Click(this, null);
        }

        //Method to be used by application teams.
        public void GetChartData(List<string> queryList, string legendX, string legendY, string labelFormat)
        { }
        public void GetChartData(int chartIndex)  //List<string> queryList, string legendX, string legendY, string labelFormat)
        {
           

            this.chart1.Series[0].Points.Clear();

            this.chart1.Series[1].Points.Clear();

            chart1.Titles.Clear();
            //modified from PACS
            this.chart1.Series[0].Color = Color.Red;

            this.chart1.Series[1].Color = Color.Blue;

              chartObj = new ChartObject(chartObjectStrings[chartIndex]);
              //textBox1.Text = chartObj.ToString();
            // string myChartTitleString = chartObj.Title;
            Title _chartTitle = new Title(chartObj.Title, Docking.Top, new Font("Verdana", 12, FontStyle.Bold), Color.Black);
            chart1.Titles.Add(_chartTitle);
            chart1.ChartAreas[0].Visible = true;
            //  chart1.ChartAreas[0].AxisY.LabelStyle.Format = chartObj.Y1VarFormat ;
            chart1.ChartAreas[0].Axes[0].Title = chartObj.XVarLegend;
            chart1.ChartAreas[0].Axes[1].Title = chartObj.Y1VarLegend;
            this.chart1.Series[0].LegendText = chartObj.Y1VarLegend;
            //modified from PACS, for X1 nad Y1 only
            if (chartObj.Y2VarLegend != null)
            {
                this.chart1.Series[1].LegendText = chartObj.Y2VarLegend;
            }

            foreach (Series series in this.chart1.Series)
            {
                if(chartObj.ChartType != null || chartObj.ChartType != "")
                {
                    series.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), chartObj.ChartType, true);
                }
                
            }


            // queryList.RemoveAt(1);
            // int fieldLength = 0;
            queryList = Utilities.DataBaseUtility.GetList(textBox_Query.Text);
            if (queryList.Count < 2) { MessageBox.Show("Error in reading tables for" + textBox_Query.Text); return; }
            queryList.RemoveAt(0);  //  remove names
            try
            {
                foreach (var value in queryList)
                {
                    string[] fields = value.Split(',');

                    //  if (fieldLength == 0 && fields.Length == 4)
                    //if (fields.Length == 3)
                    //{
                    //    this.chart1.Series[0].Name = chartObj.Y1VarName;  //  fields[1].ToString();
                    //    this.chart1.Series[1].Name = chartObj.Y2VarName;  //  fields[2].ToString();
                    //    fieldLength++;
                    //}
                    //else
                    //{ MessageBox.Show("Error in reading tables for" + chartObj.Query); return; } 
                    ////if (fieldLength == 0 && fields.Length == 3)
                    //{
                    //    this.chart1.Series[0].Name = fields[1].ToString();
                    //    this.chart1.Series[1].Name = "";
                    //    fieldLength++;
                    //}
                    //else
                    //{
                    if (chartObj.Y2VarLegend != null)
                    {
                        this.chart1.Series[1].Points.AddXY(fields[0].ToString(), fields[2].ToString());
                    }
                    this.chart1.Series[0].Points.AddXY(fields[0].ToString(), fields[1].ToString());
                    //if (fields.Length == 3)
                    //{
                    //}
                    //}
                }
                for (int i = 0; i < queryList.Count; i++)
                {
                    if (chartObj.Y1VarColor == "Red")
                        this.chart1.Series[0].Points[i].Color = Color.Red;
                    if (chartObj.Y1VarColor.ToString().Trim() == "White")
                        this.chart1.Series[0].Points[i].Color = Color.White;
                    //if (chartObj.Y2VarLegend != null)
                    //{
                    //    if (chartObj.Y2VarColor.ToString().Trim() == "Blue")
                    //        this.chart1.Series[1].Points[i].Color = Color.Blue;
                    //}
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in GetChartData - " + e.Message);
            }
        }

        //Event handler to fetch and pass arguments to GetChartData() 
        public void cbx_Reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chartIndex = cbo_Reports.SelectedIndex;
            //  chart1.ChartAreas[0].Visible = false;
            int startIndex = bigString.IndexOf("**" + chartIndex.ToString())+3;
            if (startIndex < 0)
            { MessageBox.Show("could not find : " + "**" + chartIndex.ToString()); return; }
            int lastIndex = bigString.IndexOf("**" + (chartIndex + 1));
            if (lastIndex < 0) //lastIndex = bigString.Length;
            {
                lastIndex = bigString.IndexOf("**end");
                // MessageBox.Show("could not find : " + "**" + chartIndex.ToString()); return;
            }
            int strLength = lastIndex - startIndex - 1;
            textBox_Data.Text = bigString.Substring(startIndex, strLength);
            chartObj = new ChartObject(chartObjectStrings[chartIndex]);
            textBox_Var1.Text = chartObj.Y1VarLegend;
            //modified for PACS, for X1 and Y1 only
            if (chartObj.Y2VarLegend != null)
            {
                textBox_Var2.Text = chartObj.Y2VarLegend;
            }
            textBox_ReportTitle.Text = chartObj.Title;
            textBox_ChartType.Text = chartObj.ChartType;
            textBox_Query.Text = chartObj.Query;
            label_SelectColor1.Visible = true;
            label_SelectColor2.Visible = true;
        }

        //public virtual void buildReportQuery()
        //{
        //    List<string> queryList = null;
        //    char delimiter = '-';
        //    string[] reportParams = cbo_Reports.SelectedItem.ToString().Split(delimiter);

        //    // int  reportNumber = Convert.ToInt32(reportParams[0]);
        //    chartTitle = reportParams[1].ToString().Trim();
        //    string query = reportParams[2].ToString().Trim();
        //    string legendX = reportParams[3].ToString().Trim();
        //    string legendY = reportParams[4].ToString().Trim();
        //    string labelFormat = reportParams[5].ToString().Trim();
        //    queryList = Utilities.DataBaseUtility.GetList(query);

        //    GetChartData(queryList, legendX, legendY, labelFormat);
        //}

        //Populate combobox of chart types
        private void LoadChartTypes()
        {

            foreach (var value in System.Enum.GetValues(typeof(SeriesChartType)))
            {
                cboChartType.Items.Add(value.ToString());
            }

        }


        //Event handler to change chart types
        private void cboChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboChartType.Items.Clear();
            //GetChartData();

            this.chart1.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cboChartType.SelectedItem.ToString(), true);
            this.chart1.Series[1].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cboChartType.SelectedItem.ToString(), true);
            if (chart1.Series[1].ChartType.ToString().Trim() == "FastLine")
            {
                chart1.Series[1].ChartType = SeriesChartType.Point;
                chart1.Series[0].BorderWidth = 8;
                chart1.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                chart1.Series[1].BorderWidth = 8;
                chart1.Series[1].BorderDashStyle = ChartDashStyle.Solid;
                chart1.Series[0].Color = Color.Red;
                chart1.Series[1].Color = Color.Blue;
            }
            if (chart1.Series[1].ChartType.ToString().Trim() == "StepLine")
            {
                chart1.Series[1].ChartType = SeriesChartType.FastLine;
                chart1.Series[1].BorderWidth = 8;
                chart1.Series[1].BorderDashStyle = ChartDashStyle.Solid;
                chart1.Series[0].BorderWidth = 8;
                chart1.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                chart1.Series[0].Color = Color.Red;
                chart1.Series[1].Color = Color.Blue;
            }
        }

        private void btn_generateChart_Click(object sender, EventArgs e)
        {
            try
            {
                queryList = Utilities.DataBaseUtility.GetList(textBox_Query.Text);

                GetChartData(chartIndex);   //queryList, chartObj.XVarLegend , chartObj.Y1VarLegend , chartObj.Y1VarFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while generating chart");
                //textBox1.Text = chartObj.ToString();
            }
         //   textBox_Data.Visible = false;
        }


        private void ThreadMethod()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog1.FileName;
                    txtBox_FilePath.Text = filepath;
                    btn_DisplayData_Click(this, null);
                }
            }
            catch (Exception exception) { MessageBox.Show("Error while opening dialogbox - " + exception.Message); }

        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {

            Thread newThread = new Thread(new ThreadStart(ThreadMethod));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void btn_SelectChart_Click(object sender, EventArgs e)
        {
            label_SelectColor1.Visible = true;
            label_SelectColor2.Visible = true;
        }
        private void btn_DisplayData_Click(object sender, EventArgs e)
        {
            chartIndex = 0;
            bigString = "";
            string _subString = "";
            chartObjectStrings = new String[10] { "", "", "", "", "", "", "", "", "", "" };
            filepath = txtBox_FilePath.Text;
            List<string> _list = new List<string>();
            cbo_Reports.Items.Clear();
            cbo_Reports.Items.Add("select reports from this list");
            //  try
            {
                System.IO.FileStream infile = new System.IO.FileStream(filepath, System.IO.FileMode.Open);
                System.IO.StreamReader reader = new System.IO.StreamReader(infile);
                string inputstr = reader.ReadLine();
                while (inputstr != null)
                {
                    if (inputstr.Substring(0, 2) == "**")
                    {
                        if (inputstr.Substring(0, 5) == "**end")
                        {
                            chartObjectStrings[chartIndex] = _subString;
                            bigString += inputstr.Substring(0, 5) + "\r\n";
                            return;
                        }
                        int chartIndex2 = Int32.Parse(inputstr.Substring(2, 2)) - 1;
                        if (chartIndex != chartIndex2) { MessageBox.Show("Error in loading chartObjectStrings[" + chartIndex.ToString() + "]"); return; }
                        cbo_Reports.Items.Add(inputstr);


                        chartObjectStrings[chartIndex] = _subString;
                        _subString = "";
                        chartIndex++;

                    }
                    _list.Add(inputstr);
                    _subString += inputstr + "\r\n";
                    bigString += inputstr + "\r\n";
                    inputstr = reader.ReadLine();
                }
                reader.Close();
            }

            System.Text.StringBuilder strBldr = new StringBuilder();
            foreach (string _record in _list)
            {
                strBldr.Append(_record.ToString());
                strBldr.Append("\r\n");
            }

            //  txtBox_Data.Text = strBldr.ToString();
        }

        private void btn_RefreshData_Click(object sender, EventArgs e)
        {
            cbo_Reports.Items.Clear();
            List<string> list = new List<string>(
                          textBox_Data.Text.Split(new string[] { "\r\n" },
                           StringSplitOptions.RemoveEmptyEntries));

            foreach (string str in list)
            {
                cbo_Reports.Items.Add(str);
            }
        }
    }
}
