using System;
using System.Windows.Forms;

namespace Islington
{
    public partial class SalesBilling : Form
    {
        public SalesBilling()
        {
            InitializeComponent();
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            // Sample data for invoices, this should be replaced with actual data retrieval logic
            dataGridViewInvoices.DataSource = new System.Data.DataTable();
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            // Add logic to add a new invoice
            // You would typically gather data from the textboxes and save it to your database
            string customerName = textBoxCustomerName.Text;
            string customerContact = textBoxCustomerContact.Text;
            string product = textBoxProduct.Text;
            int quantity;
            decimal price;

            if (int.TryParse(textBoxQuantity.Text, out quantity) && decimal.TryParse(textBoxPrice.Text, out price))
            {
                // Code to add the invoice to the database
                MessageBox.Show("Invoice added successfully!");

                // Clear the textboxes after adding
                textBoxCustomerName.Clear();
                textBoxCustomerContact.Clear();
                textBoxProduct.Clear();
                textBoxQuantity.Clear();
                textBoxPrice.Clear();

                // Reload the invoice list
                LoadInvoices();
            }
            else
            {
                MessageBox.Show("Please enter valid quantity and price.");
            }
        }

        private void buttonEditInvoice_Click(object sender, EventArgs e)
        {
            // Add logic to edit the selected invoice
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                // Get the selected invoice data
                var selectedRow = dataGridViewInvoices.SelectedRows[0];
                // Fill the textboxes with the selected invoice data
                // Example:
                // textBoxCustomerName.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                // textBoxCustomerContact.Text = selectedRow.Cells["CustomerContact"].Value.ToString();
                // textBoxProduct.Text = selectedRow.Cells["Product"].Value.ToString();
                // textBoxQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                // textBoxPrice.Text = selectedRow.Cells["Price"].Value.ToString();

                // After editing, update the invoice in the database and reload the list
                MessageBox.Show("Invoice edited successfully!");
                LoadInvoices();
            }
            else
            {
                MessageBox.Show("Please select an invoice to edit.");
            }
        }

        private void buttonDeleteInvoice_Click(object sender, EventArgs e)
        {
            // Add logic to delete the selected invoice
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                // Get the selected invoice data
                var selectedRow = dataGridViewInvoices.SelectedRows[0];
                // Code to delete the invoice from the database
                MessageBox.Show("Invoice deleted successfully!");

                // Reload the invoice list
                LoadInvoices();
            }
            else
            {
                MessageBox.Show("Please select an invoice to delete.");
            }
        }
    }
}
