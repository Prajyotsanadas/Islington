using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class ReportsPage : Form
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

        private void buttonSalesReport_Click(object sender, EventArgs e)
        {
            // Generate and display the sales report
            DataTable salesReport = GenerateSalesReport();
            dataGridViewReports.DataSource = salesReport;
        }

        private void buttonInventoryReport_Click(object sender, EventArgs e)
        {
            // Generate and display the inventory report
            DataTable inventoryReport = GenerateInventoryReport();
            dataGridViewReports.DataSource = inventoryReport;
        }

        private void buttonPurchaseReport_Click(object sender, EventArgs e)
        {
            // Generate and display the purchase report
            DataTable purchaseReport = GeneratePurchaseReport();
            dataGridViewReports.DataSource = purchaseReport;
        }

        private DataTable GenerateSalesReport()
        {
            // Sample data for sales report, replace with actual data retrieval logic
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Total Sales");

            dataTable.Rows.Add("2023-07-20", "Product 1", 10, 1000);
            dataTable.Rows.Add("2023-07-21", "Product 2", 5, 750);
            dataTable.Rows.Add("2023-07-22", "Product 3", 7, 1400);

            return dataTable;
        }

        private DataTable GenerateInventoryReport()
        {
            // Sample data for inventory report, replace with actual data retrieval logic
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            dataTable.Rows.Add("Product 1", 50, 100);
            dataTable.Rows.Add("Product 2", 20, 150);
            dataTable.Rows.Add("Product 3", 5, 200);

            return dataTable;
        }

        private DataTable GeneratePurchaseReport()
        {
            // Sample data for purchase report, replace with actual data retrieval logic
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Supplier");
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Total Purchase");

            dataTable.Rows.Add("2023-07-20", "Supplier 1", "Product 1", 30, 3000);
            dataTable.Rows.Add("2023-07-21", "Supplier 2", "Product 2", 15, 2250);
            dataTable.Rows.Add("2023-07-22", "Supplier 3", "Product 3", 10, 2000);

            return dataTable;
        }
    }
}
