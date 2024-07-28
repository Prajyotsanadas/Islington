using System;
using System.Windows.Forms;

namespace Islington
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            // Navigate to User Management Page
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
            // Navigate to System Settings Page
            SystemSettings systemSettings = new SystemSettings();
            systemSettings.Show();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            // Navigate to View Logs Page
            AuditLogs auditLogs = new AuditLogs();
            auditLogs.Show();
        }

        private void btnReportsAndAnalytics_Click(object sender, EventArgs e)
        {
            // Navigate to Reports and Analytics Page
            ReportsAndAnalytics reportsAndAnalytics = new ReportsAndAnalytics();
            reportsAndAnalytics.Show();
        }
    }
}
