namespace Islington
{
    partial class ReportsAndAnalytics
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ComboBox cbReportType;
        private Button btnGenerateReport;
        private DataGridView dgvReportResults;
        private Label lblReportType;

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
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReportResults = new System.Windows.Forms.DataGridView();
            this.lblReportType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports & Analytics";
            // 
            // cbReportType
            // 
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "System Usage Report",
            "User Activity Report"});
            this.cbReportType.Location = new System.Drawing.Point(150, 80);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(200, 24);
            this.cbReportType.TabIndex = 1;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(50, 83);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(94, 17);
            this.lblReportType.TabIndex = 2;
            this.lblReportType.Text = "Report Type:";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(370, 80);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReportResults
            // 
            this.dgvReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportResults.Location = new System.Drawing.Point(50, 130);
            this.dgvReportResults.Name = "dgvReportResults";
            this.dgvReportResults.RowHeadersWidth = 51;
            this.dgvReportResults.RowTemplate.Height = 24;
            this.dgvReportResults.Size = new System.Drawing.Size(700, 300);
            this.dgvReportResults.TabIndex = 4;
            // 
            // ReportsAndAnalytics
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReportResults);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cbReportType);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportsAndAnalytics";
            this.Text = "Reports and Analytics";
            this.Load += new System.EventHandler(this.ReportsAndAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


