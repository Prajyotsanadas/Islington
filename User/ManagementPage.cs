using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class ManagementPage : Form
    {
        private string selectedTab;

        public ManagementPage(string tab)
        {
            InitializeComponent();
            selectedTab = tab;
            LoadData();
            SelectTab();
        }

        private void SelectTab()
        {
            switch (selectedTab)
            {
                case "Purchases":
                    tabControlManagement.SelectedTab = tabPagePurchases;
                    break;
                case "Customers":
                    tabControlManagement.SelectedTab = tabPageCustomers;
                    break;
                case "Suppliers":
                    tabControlManagement.SelectedTab = tabPageSuppliers;
                    break;
            }
        }

        private void LoadData()
        {
            // Load sample data for purchases, customers, and suppliers
            LoadPurchases();
            LoadCustomers();
            LoadSuppliers();
        }

        private void LoadPurchases()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Supplier Name");
            dataTable.Columns.Add("Items Purchased");
            dataTable.Rows.Add("Supplier 1", "Item A");
            dataTable.Rows.Add("Supplier 2", "Item B");
            dataTable.Rows.Add("Supplier 3", "Item C");
            dataGridViewPurchases.DataSource = dataTable;
        }

        private void LoadCustomers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Customer Details");
            dataTable.Rows.Add("Customer 1", "Details A");
            dataTable.Rows.Add("Customer 2", "Details B");
            dataTable.Rows.Add("Customer 3", "Details C");
            dataGridViewCustomers.DataSource = dataTable;
        }

        private void LoadSuppliers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Supplier Name");
            dataTable.Columns.Add("Supplier Details");
            dataTable.Rows.Add("Supplier 1", "Details A");
            dataTable.Rows.Add("Supplier 2", "Details B");
            dataTable.Rows.Add("Supplier 3", "Details C");
            dataGridViewSuppliers.DataSource = dataTable;
        }

        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            // Add new purchase record
            string supplierName = textBoxSupplierName.Text;
            string itemsPurchased = textBoxItemsPurchased.Text;

            if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(itemsPurchased))
            {
                MessageBox.Show("Please enter valid purchase details.", "Validation Error");
                return;
            }

            DataTable dataTable = (DataTable)dataGridViewPurchases.DataSource;
            dataTable.Rows.Add(supplierName, itemsPurchased);

            textBoxSupplierName.Clear();
            textBoxItemsPurchased.Clear();

            MessageBox.Show("Purchase added successfully!", "Success");
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            // Add new customer record
            string customerName = textBoxCustomerName.Text;
            string customerDetails = textBoxCustomerDetails.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerDetails))
            {
                MessageBox.Show("Please enter valid customer details.", "Validation Error");
                return;
            }

            DataTable dataTable = (DataTable)dataGridViewCustomers.DataSource;
            dataTable.Rows.Add(customerName, customerDetails);

            textBoxCustomerName.Clear();
            textBoxCustomerDetails.Clear();

            MessageBox.Show("Customer added successfully!", "Success");
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            // Update selected customer record
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCustomers.SelectedRows[0];
                string customerName = textBoxCustomerName.Text;
                string customerDetails = textBoxCustomerDetails.Text;

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerDetails))
                {
                    MessageBox.Show("Please enter valid customer details.", "Validation Error");
                    return;
                }

                selectedRow.Cells["Customer Name"].Value = customerName;
                selectedRow.Cells["Customer Details"].Value = customerDetails;

                textBoxCustomerName.Clear();
                textBoxCustomerDetails.Clear();

                MessageBox.Show("Customer updated successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a customer to update.", "Selection Error");
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Delete selected customer record
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCustomers.SelectedRows[0];
                dataGridViewCustomers.Rows.Remove(selectedRow);

                textBoxCustomerName.Clear();
                textBoxCustomerDetails.Clear();

                MessageBox.Show("Customer deleted successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Selection Error");
            }
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            // Add new supplier record
            string supplierName = textBoxSupplierName.Text;
            string supplierDetails = textBoxSupplierDetails.Text;

            if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(supplierDetails))
            {
                MessageBox.Show("Please enter valid supplier details.", "Validation Error");
                return;
            }

            DataTable dataTable = (DataTable)dataGridViewSuppliers.DataSource;
            dataTable.Rows.Add(supplierName, supplierDetails);

            textBoxSupplierName.Clear();
            textBoxSupplierDetails.Clear();

            MessageBox.Show("Supplier added successfully!", "Success");
        }

        private void buttonUpdateSupplier_Click(object sender, EventArgs e)
        {
            // Update selected supplier record
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSuppliers.SelectedRows[0];
                string supplierName = textBoxSupplierName.Text;
                string supplierDetails = textBoxSupplierDetails.Text;

                if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(supplierDetails))
                {
                    MessageBox.Show("Please enter valid supplier details.", "Validation Error");
                    return;
                }

                selectedRow.Cells["Supplier Name"].Value = supplierName;
                selectedRow.Cells["Supplier Details"].Value = supplierDetails;

                textBoxSupplierName.Clear();
                textBoxSupplierDetails.Clear();

                MessageBox.Show("Supplier updated successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a supplier to update.", "Selection Error");
            }
        }

        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            // Delete selected supplier record
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSuppliers.SelectedRows[0];
                dataGridViewSuppliers.Rows.Remove(selectedRow);

                textBoxSupplierName.Clear();
                textBoxSupplierDetails.Clear();

                MessageBox.Show("Supplier deleted successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a supplier to delete.", "Selection Error");
            }
        }
    }
}
