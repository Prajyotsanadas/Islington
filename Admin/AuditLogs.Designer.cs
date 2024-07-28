namespace Islington
{
    partial class AuditLogs
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private DataGridView dgvLogs;
        private Button btnRefresh;
        private Button btnSave;

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
            lblTitle = new Label();
            dgvLogs = new DataGridView();
            btnRefresh = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(250, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audit Logs";
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(50, 70);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.RowTemplate.Height = 24;
            dgvLogs.Size = new Size(700, 300);
            dgvLogs.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(50, 380);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += new EventHandler(btnRefresh_Click);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new EventHandler(btnSave_Click);
            // 
            // AuditLogs
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(dgvLogs);
            Controls.Add(lblTitle);
            Name = "AuditLogs";
            Text = "Audit Logs";
            Load += new EventHandler(AuditLogs_Load);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

