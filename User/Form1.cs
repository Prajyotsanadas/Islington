using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class Form1 : Form
    {
        private SQLiteConnectionManager dbManager;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            dbManager = new SQLiteConnectionManager("IslingtonDB.sqlite");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get email and password input
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            // Check if email and password fields are filled
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all credentials.", "Validation Error");
                return;
            }

            // Authenticate user
            string query = $"SELECT * FROM Users WHERE Email='{email}' AND Password='{password}'";
            DataTable result = dbManager.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                // Check email domain
                if (email.EndsWith("@admin.com"))
                {
                    MessageBox.Show("Login successful as Admin!", "Success");
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else if (email.EndsWith("@user.com"))
                {
                    MessageBox.Show("Login successful as User!", "Success");
                    CustomerDashboard customerDashboard = new CustomerDashboard(email);
                    customerDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Access denied. Please use a valid email.", "Access Denied");
                    return;
                }

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Hide Form1 and show Form2
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
