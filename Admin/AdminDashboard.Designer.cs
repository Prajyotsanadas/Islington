namespace Islington
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsageStats;
        private Button btnUserManagement;
        private Button btnAuditLogs;
        private Button btnReportsAndAnalytics;
        private Button btnSystemSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsageStats = new System.Windows.Forms.Label();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnAuditLogs = new System.Windows.Forms.Button();
            this.btnReportsAndAnalytics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // lblUsageStats
            // 
            this.lblUsageStats.AutoSize = true;
            this.lblUsageStats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsageStats.Location = new System.Drawing.Point(50, 80);
            this.lblUsageStats.Name = "lblUsageStats";
            this.lblUsageStats.Size = new System.Drawing.Size(120, 23);
            this.lblUsageStats.TabIndex = 1;
            this.lblUsageStats.Text = "Usage Stats:";
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(50, 120);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(200, 50);
            this.btnUserManagement.TabIndex = 2;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnSystemSettings
            // 
            this.btnSystemSettings.Location = new System.Drawing.Point(50, 190);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSystemSettings.TabIndex = 3;
            this.btnSystemSettings.Text = "System Settings";
            this.btnSystemSettings.UseVisualStyleBackColor = true;
            this.btnSystemSettings.Click += new System.EventHandler(this.btnSystemSettings_Click);
            // 
            // btnViewLogs
            // 
            this.btnAuditLogs.Location = new System.Drawing.Point(50, 260);
            this.btnAuditLogs.Name = "btnAuditLogs";
            this.btnAuditLogs.Size = new System.Drawing.Size(200, 50);
            this.btnAuditLogs.TabIndex = 4;
            this.btnAuditLogs.Text = "Audit Logs";
            this.btnAuditLogs.UseVisualStyleBackColor = true;
            this.btnAuditLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnReportsAndAnalytics
            // 
            this.btnReportsAndAnalytics.Location = new System.Drawing.Point(50, 330);
            this.btnReportsAndAnalytics.Name = "btnReportsAndAnalytics";
            this.btnReportsAndAnalytics.Size = new System.Drawing.Size(200, 50);
            this.btnReportsAndAnalytics.TabIndex = 5;
            this.btnReportsAndAnalytics.Text = "Reports and Analytics";
            this.btnReportsAndAnalytics.UseVisualStyleBackColor = true;
            this.btnReportsAndAnalytics.Click += new System.EventHandler(this.btnReportsAndAnalytics_Click);
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportsAndAnalytics);
            this.Controls.Add(this.btnAuditLogs);
            this.Controls.Add(this.btnSystemSettings);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.lblUsageStats);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
