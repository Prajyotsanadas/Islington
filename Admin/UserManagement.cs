using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class UserManagement : Form
    {
        private SQLiteConnectionManager dbManager;

        public UserManagement()
        {
            InitializeComponent();
            dbManager = new SQLiteConnectionManager("IslingtonDB.sqlite");
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT * FROM Users";
            DataTable usersTable = dbManager.ExecuteQuery(query);
            dgvUsers.DataSource = usersTable;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                txtUserName.Text = selectedRow.Cells["FullName"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
                cbRole.SelectedItem = selectedRow.Cells["Role"].Value?.ToString();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string email = dgvUsers.SelectedRows[0].Cells["Email"].Value?.ToString() ?? string.Empty;
                string query = $"DELETE FROM Users WHERE Email = '{email}'";
                if (dbManager.ExecuteNonQuery(query))
                {
                    MessageBox.Show("User deleted successfully.", "Success");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtUserName.Text;
            string email = txtEmail.Text;
            string role = cbRole.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error");
                return;
            }

            string query = $"INSERT INTO Users (FullName, Email, Role) VALUES ('{fullName}', '{email}', '{role}')";
            if (dbManager.ExecuteNonQuery(query))
            {
                MessageBox.Show("User added/updated successfully.", "Success");
                LoadUsers();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add/update user.", "Error");
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUserName.Text = row.Cells["FullName"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                cbRole.SelectedItem = row.Cells["Role"].Value?.ToString();
            }
        }

        private void ClearForm()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            cbRole.SelectedIndex = -1;
        }
    }
}
