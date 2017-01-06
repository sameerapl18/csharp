using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement
{
    public partial class Reports : Applications.Materials.MaterialsManagement.MaterialsManagement_Template
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Applications.Materials.MaterialsManagement.Top5SoldMaterials report1 = new Applications.Materials.MaterialsManagement.Top5SoldMaterials();
            CrystalReport_Viewer cr = new CrystalReport_Viewer();
            cr.crystalReportViewer1.ReportSource = report1;
            cr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Applications.Materials.MaterialsManagement.InventoryReport report2 = new Applications.Materials.MaterialsManagement.InventoryReport();
            CrystalReport_Viewer cr1 = new CrystalReport_Viewer();
            cr1.crystalReportViewer1.ReportSource = report2;
            cr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Applications.Materials.MaterialsManagement.PurchaseOrders_time report3 = new Applications.Materials.MaterialsManagement.PurchaseOrders_time();
            CrystalReport_Viewer cr2 = new CrystalReport_Viewer();
            cr2.crystalReportViewer1.ReportSource = report3;
            cr2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Applications.Materials.MaterialsManagement.InventoryItems report4 = new Applications.Materials.MaterialsManagement.InventoryItems();
            CrystalReport_Viewer cr3 = new CrystalReport_Viewer();
            cr3.crystalReportViewer1.ReportSource = report4;
            cr3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Applications.Materials.MaterialsManagement.DeliveryReports report5 = new Applications.Materials.MaterialsManagement.DeliveryReports();
            CrystalReport_Viewer cr4 = new CrystalReport_Viewer();
            cr4.crystalReportViewer1.ReportSource = report5;
            cr4.Show();
        }
    }
}
