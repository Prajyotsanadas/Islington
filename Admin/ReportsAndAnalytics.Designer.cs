using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class ReportsAndAnalytics : Form
    {
        private SQLiteConnectionManager dbManager;

        public ReportsAndAnalytics()
        {
            InitializeComponent();
            dbManager = new SQLiteConnectionManager("IslingtonDB.sqlite");
        }

        private void ReportsAndAnalytics_Load(object sender, EventArgs e)
        {
            cbReportType.SelectedIndex = 0; // Set default selected item
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cbReportType.SelectedItem.ToString();
            DataTable reportData = null;

            switch (reportType)
            {
                case "System Usage Report":
                    reportData = GenerateSystemUsageReport();
                    break;
                case "Business Performance Report":
                    reportData = GenerateBusinessPerformanceReport();
                    break;
                case "User Activity Report":
                    reportData = GenerateUserActivityReport();
                    break;
            }

            dgvReportResults.DataSource = reportData;
        }

        private DataTable GenerateSystemUsageReport()
        {
            string query = @"SELECT UserEmail, Action, Timestamp 
                             FROM AuditLogs 
                             WHERE Action = 'Login' OR Action = 'Logout' 
                             ORDER BY Timestamp DESC";
            return dbManager.ExecuteQuery(query);
        }

        private DataTable GenerateBusinessPerformanceReport()
        {
            string query = @"SELECT SaleDate, ProductName, Quantity, Price, (Quantity * Price) AS Total 
                             FROM Sales 
                             ORDER BY SaleDate DESC";
            return dbManager.ExecuteQuery(query);
        }

        private DataTable GenerateUserActivityReport()
        {
            string query = @"SELECT UserEmail, Action, Timestamp, Description 
                             FROM AuditLogs 
                             ORDER BY Timestamp DESC";
            return dbManager.ExecuteQuery(query);
        }
    }
}
