namespace Islington
{
    partial class SystemSettings
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblTaxRate;
        private TextBox txtTaxRate;
        private Button btnSaveTaxRate;
        private Label lblCurrency;
        private ComboBox cbCurrency;
        private Button btnSaveCurrency;
        private Button btnBackupDatabase;
        private Button btnRestoreDatabase;

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
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.btnSaveTaxRate = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.btnSaveCurrency = new System.Windows.Forms.Button();
            this.btnBackupDatabase = new System.Windows.Forms.Button();
            this.btnRestoreDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Settings";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(50, 80);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(67, 17);
            this.lblTaxRate.TabIndex = 1;
            this.lblTaxRate.Text = "Tax Rate:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(150, 80);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 22);
            this.txtTaxRate.TabIndex = 2;
            // 
            // btnSaveTaxRate
            // 
            this.btnSaveTaxRate.Location = new System.Drawing.Point(270, 80);
            this.btnSaveTaxRate.Name = "btnSaveTaxRate";
            this.btnSaveTaxRate.Size = new System.Drawing.Size(100, 30);
            this.btnSaveTaxRate.TabIndex = 3;
            this.btnSaveTaxRate.Text = "Save";
            this.btnSaveTaxRate.UseVisualStyleBackColor = true;
            this.btnSaveTaxRate.Click += new System.EventHandler(this.btnSaveTaxRate_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(50, 130);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(68, 17);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "Currency:";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "INR"});
            this.cbCurrency.Location = new System.Drawing.Point(150, 130);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(100, 24);
            this.cbCurrency.TabIndex = 5;
            // 
            // btnSaveCurrency
            // 
            this.btnSaveCurrency.Location = new System.Drawing.Point(270, 130);
            this.btnSaveCurrency.Name = "btnSaveCurrency";
            this.btnSaveCurrency.Size = new System.Drawing.Size(100, 30);
            this.btnSaveCurrency.TabIndex = 6;
            this.btnSaveCurrency.Text = "Save";
            this.btnSaveCurrency.UseVisualStyleBackColor = true;
            this.btnSaveCurrency.Click += new System.EventHandler(this.btnSaveCurrency_Click);
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.Location = new System.Drawing.Point(50, 200);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.Size = new System.Drawing.Size(150, 30);
            this.btnBackupDatabase.TabIndex = 7;
            this.btnBackupDatabase.Text = "Backup Database";
            this.btnBackupDatabase.UseVisualStyleBackColor = true;
            this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Location = new System.Drawing.Point(220, 200);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(150, 30);
            this.btnRestoreDatabase.TabIndex = 8;
            this.btnRestoreDatabase.Text = "Restore Database";
            this.btnRestoreDatabase.UseVisualStyleBackColor = true;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // SystemSettings
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestoreDatabase);
            this.Controls.Add(this.btnBackupDatabase);
            this.Controls.Add(this.btnSaveCurrency);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnSaveTaxRate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblTitle);
            this.Name = "SystemSettings";
            this.Text = "System Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

