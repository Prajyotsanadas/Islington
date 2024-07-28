using System;
using System.Windows.Forms;

namespace Islington
{
    public partial class Form2 : Form
    {
        private SQLiteConnectionManager dbManager;

        public Form2()
        {
            InitializeComponent();
            dbManager = new SQLiteConnectionManager("IslingtonDB.sqlite");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check if all fields are filled
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error");
                return;
            }

            // Check if email contains '@'
            if (!email.Contains("@"))
            {
                MessageBox.Show("Invalid email address. Please include '@' in the email.", "Validation Error");
                return;
            }

            // Check if phone number is numeric and 10 digits long
            if (!long.TryParse(phoneNumber, out _) || phoneNumber.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error");
                return;
            }

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error");
                return;
            }

            // Insert new user into the database
            string query = $"INSERT INTO Users (FullName, Email, PhoneNumber, Password) VALUES ('{fullName}', '{email}', '{phoneNumber}', '{password}')";
            if (dbManager.ExecuteNonQuery(query))
            {
                MessageBox.Show("Registration successful!", "Success");
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Registration Failed");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Hide Form2 and show Form1
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
