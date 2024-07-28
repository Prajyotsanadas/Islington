using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Islington
{
    public partial class AuditLogs : Form
    {
        private SQLiteConnectionManager dbManager;
        private DataTable logsTable;
        private SQLiteDataAdapter dataAdapter;

        public AuditLogs()
        {
            InitializeComponent();
            dbManager = new SQLiteConnectionManager("IslingtonDB.sqlite");
        }

        private void AuditLogs_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            string query = "SELECT * FROM AuditLogs ORDER BY Timestamp DESC";
            dataAdapter = new SQLiteDataAdapter(query, dbManager.ConnectionString);
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            logsTable = new DataTable();
            dataAdapter.Fill(logsTable);
            dgvLogs.DataSource = logsTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Commit changes to the database
                dataAdapter.Update(logsTable);
                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
