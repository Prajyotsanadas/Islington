using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class InventoryPage : Form
    {
        public InventoryPage()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            // Sample data for inventory, this should be replaced with actual data retrieval logic
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            dataTable.Rows.Add("Product 1", 50, 100);
            dataTable.Rows.Add("Product 2", 20, 150);
            dataTable.Rows.Add("Product 3", 5, 200);

            dataGridViewInventory.DataSource = dataTable;

            CheckStockAlerts();
        }

        private void CheckStockAlerts()
        {
            foreach (DataGridViewRow row in dataGridViewInventory.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                if (quantity < 10)
                {
                    labelStockAlert.Text = "Stock Alert: Some products have low stock!";
                    labelStockAlert.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
            labelStockAlert.Text = "Stock Alert: All products are sufficiently stocked.";
            labelStockAlert.ForeColor = System.Drawing.Color.Green;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Add logic to add a new product
            string productName = textBoxProductName.Text;
            int quantity;
            decimal price;

            if (string.IsNullOrEmpty(productName) || !int.TryParse(textBoxQuantity.Text, out quantity) || !decimal.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid product details.", "Validation Error");
                return;
            }

            // Add the new product to the inventory (this should involve updating the actual data source)
            DataTable dataTable = (DataTable)dataGridViewInventory.DataSource;
            dataTable.Rows.Add(productName, quantity, price);

            // Clear the textboxes after adding
            textBoxProductName.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();

            // Check for stock alerts after adding a new product
            CheckStockAlerts();

            MessageBox.Show("Product added successfully!", "Success");
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            // Add logic to update the selected product
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewInventory.SelectedRows[0];
                string productName = textBoxProductName.Text;
                int quantity;
                decimal price;

                if (string.IsNullOrEmpty(productName) || !int.TryParse(textBoxQuantity.Text, out quantity) || !decimal.TryParse(textBoxPrice.Text, out price))
                {
                    MessageBox.Show("Please enter valid product details.", "Validation Error");
                    return;
                }

                // Update the product details in the inventory (this should involve updating the actual data source)
                selectedRow.Cells["Product Name"].Value = productName;
                selectedRow.Cells["Quantity"].Value = quantity;
                selectedRow.Cells["Price"].Value = price;

                // Clear the textboxes after updating
                textBoxProductName.Clear();
                textBoxQuantity.Clear();
                textBoxPrice.Clear();

                // Check for stock alerts after updating a product
                CheckStockAlerts();

                MessageBox.Show("Product updated successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Selection Error");
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            // Add logic to delete the selected product
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewInventory.SelectedRows[0];

                // Delete the product from the inventory (this should involve updating the actual data source)
                dataGridViewInventory.Rows.Remove(selectedRow);

                // Clear the textboxes after deleting
                textBoxProductName.Clear();
                textBoxQuantity.Clear();
                textBoxPrice.Clear();

                // Check for stock alerts after deleting a product
                CheckStockAlerts();

                MessageBox.Show("Product deleted successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Selection Error");
            }
        }

        private void dataGridViewInventory_SelectionChanged(object sender, EventArgs e)
        {
            // Load selected product details into the textboxes for editing
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewInventory.SelectedRows[0];
                textBoxProductName.Text = selectedRow.Cells["Product Name"].Value.ToString();
                textBoxQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                textBoxPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }
    }
}
