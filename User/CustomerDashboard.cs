using System;
using System.Windows.Forms;

namespace Islington
{
    public partial class CustomerDashboard : Form
    {
        private string userEmail;

        public CustomerDashboard(string email)
        {
            InitializeComponent();
            userEmail = email;
            CheckUserAccess();
        }

        private void CheckUserAccess()
        {
            if (!userEmail.EndsWith("@user.com"))
            {
                MessageBox.Show("Access restricted. Only users with @user.com email can access this page.", "Access Denied");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Welcome, {userEmail}", "Access Granted");
            }
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            // Navigate to Sales/Billing Page
            SalesBilling salesPage = new SalesBilling();
            salesPage.Show();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            // Navigate to Inventory Management Page
            InventoryPage inventoryPage = new InventoryPage();
            inventoryPage.Show();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            // Navigate to Reports Page
            ReportsPage reportsPage = new ReportsPage();
            reportsPage.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Logout and return to login page
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Close();
        }
    }
}
