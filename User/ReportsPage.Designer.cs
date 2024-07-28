namespace Islington
{
    partial class ReportsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalesReport = new System.Windows.Forms.Button();
            this.buttonInventoryReport = new System.Windows.Forms.Button();
            this.buttonPurchaseReport = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalesReport
            // 
            this.buttonSalesReport.Location = new System.Drawing.Point(30, 30);
            this.buttonSalesReport.Name = "buttonSalesReport";
            this.buttonSalesReport.Size = new System.Drawing.Size(150, 30);
            this.buttonSalesReport.TabIndex = 0;
            this.buttonSalesReport.Text = "Sales Report";
            this.buttonSalesReport.UseVisualStyleBackColor = true;
            this.buttonSalesReport.Click += new System.EventHandler(this.buttonSalesReport_Click);
            // 
            // buttonInventoryReport
            // 
            this.buttonInventoryReport.Location = new System.Drawing.Point(200, 30);
            this.buttonInventoryReport.Name = "buttonInventoryReport";
            this.buttonInventoryReport.Size = new System.Drawing.Size(150, 30);
            this.buttonInventoryReport.TabIndex = 1;
            this.buttonInventoryReport.Text = "Inventory Report";
            this.buttonInventoryReport.UseVisualStyleBackColor = true;
            this.buttonInventoryReport.Click += new System.EventHandler(this.buttonInventoryReport_Click);
            // 
            // buttonPurchaseReport
            // 
            this.buttonPurchaseReport.Location = new System.Drawing.Point(370, 30);
            this.buttonPurchaseReport.Name = "buttonPurchaseReport";
            this.buttonPurchaseReport.Size = new System.Drawing.Size(150, 30);
            this.buttonPurchaseReport.TabIndex = 2;
            this.buttonPurchaseReport.Text = "Purchase Report";
            this.buttonPurchaseReport.UseVisualStyleBackColor = true;
            this.buttonPurchaseReport.Click += new System.EventHandler(this.buttonPurchaseReport_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(30, 80);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowTemplate.Height = 24;
            this.dataGridViewReports.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewReports.TabIndex = 3;
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.buttonPurchaseReport);
            this.Controls.Add(this.buttonInventoryReport);
            this.Controls.Add(this.buttonSalesReport);
            this.Name = "ReportsPage";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonSalesReport;
        private System.Windows.Forms.Button buttonInventoryReport;
        private System.Windows.Forms.Button buttonPurchaseReport;
        private System.Windows.Forms.DataGridView dataGridViewReports;

        #endregion
    }
}
