using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Sales_Products
{
    public partial class Products_Main : Applications.Sales.Sales_Template
    {
        public Products_Main()
        {
            InitializeComponent();
        }
        public Products_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_SalesQuotes_Click(object sender, EventArgs e)
        {
            ListObjects Quotes_DashBoard = new ListObjects(ident, 0);
            Quotes_DashBoard.Show();
        }

        private void button_SalesOrders_Click(object sender, EventArgs e)
        {
            ListObjects Orders_DashBoard = new ListObjects(ident, 1);
            Orders_DashBoard.Show();
        }

        private void button_CrystalReport_Click(object sender, EventArgs e)
        {
            CrystalReport_Products report = new CrystalReport_Products();
            Sales_Product_Reports crystalReportForm = new Sales_Product_Reports();
            crystalReportForm.crystalReportViewer1.ReportSource = report;
            crystalReportForm.Show();
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            new Applications.Sales.Sales_Products.Chart_Products(ident).Show();
        }

        private void btn_Tableau_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://public.tableau.com/views/ProductSales_Dashboard/ProductSalesDashboard?:embed=y&:display_count=yes");
        }
        
    }
}
