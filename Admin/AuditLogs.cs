using System;
using System.Data;
using System.Windows.Forms;

namespace Islington
{
    public partial class AuditLogs : Form
    {
        private SQLiteConnectionManager dbManager;

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
            DataTable logsTable = dbManager.ExecuteQuery(query);
            dgvLogs.DataSource = logsTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender, e);
        }
    }
}
