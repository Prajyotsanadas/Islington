namespace Islington
{
    partial class ManagementPage
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
            this.tabControlManagement = new System.Windows.Forms.TabControl();
            this.tabPagePurchases = new System.Windows.Forms.TabPage();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelItemsPurchased = new System.Windows.Forms.Label();
            this.textBoxItemsPurchased = new System.Windows.Forms.TextBox();
            this.buttonAddPurchase = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerDetails = new System.Windows.Forms.TextBox();
            this.labelCustomerDetails = new System.Windows.Forms.Label();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonUpdateSupplier = new System.Windows.Forms.Button();
            this.buttonDeleteSupplier = new System.Windows.Forms.Button();
            this.textBoxSupplierDetails = new System.Windows.Forms.TextBox();
            this.labelSupplierDetails = new System.Windows.Forms.Label();
            this.tabControlManagement.SuspendLayout();
            this.tabPagePurchases.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            this.tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManagement
            // 
            this.tabControlManagement.Controls.Add(this.tabPagePurchases);
            this.tabControlManagement.Controls.Add(this.tabPageCustomers);
            this.tabControlManagement.Controls.Add(this.tabPageSuppliers);
            this.tabControlManagement.Location = new System.Drawing.Point(12, 12);
            this.tabControlManagement.Name = "tabControlManagement";
            this.tabControlManagement.SelectedIndex = 0;
            this.tabControlManagement.Size = new System.Drawing.Size(776, 426);
            this.tabControlManagement.TabIndex = 0;
            // 
            // tabPagePurchases
            // 
            this.tabPagePurchases.Controls.Add(this.buttonAddPurchase);
            this.tabPagePurchases.Controls.Add(this.textBoxItemsPurchased);
            this.tabPagePurchases.Controls.Add(this.labelItemsPurchased);
            this.tabPagePurchases.Controls.Add(this.textBoxSupplierName);
            this.tabPagePurchases.Controls.Add(this.labelSupplierName);
            this.tabPagePurchases.Controls.Add(this.dataGridViewPurchases);
            this.tabPagePurchases.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchases.Name = "tabPagePurchases";
            this.tabPagePurchases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchases.Size = new System.Drawing.Size(768, 397);
            this.tabPagePurchases.TabIndex = 0;
            this.tabPagePurchases.Text = "Purchases";
            this.tabPagePurchases.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.labelCustomerDetails);
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerDetails);
            this.tabPageCustomers.Controls.Add(this.labelCustomerName);
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerName);
            this.tabPageCustomers.Controls.Add(this.buttonDeleteCustomer);
            this.tabPageCustomers.Controls.Add(this.buttonUpdateCustomer);
            this.tabPageCustomers.Controls.Add(this.buttonAddCustomer);
            this.tabPageCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(768, 397);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Controls.Add(this.labelSupplierDetails);
            this.tabPageSuppliers.Controls.Add(this.textBoxSupplierDetails);
            this.tabPageSuppliers.Controls.Add(this.buttonDeleteSupplier);
            this.tabPageSuppliers.Controls.Add(this.buttonUpdateSupplier);
            this.tabPageSuppliers.Controls.Add(this.buttonAddSupplier);
            this.tabPageSuppliers.Controls.Add(this.dataGridViewSuppliers);
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppliers.Size = new System.Drawing.Size(768, 397);
            this.tabPageSuppliers.TabIndex = 2;
            this.tabPageSuppliers.Text = "Suppliers";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.RowHeadersWidth = 51;
            this.dataGridViewPurchases.RowTemplate.Height = 24;
            this.dataGridViewPurchases.Size = new System.Drawing.Size(756, 250);
            this.dataGridViewPurchases.TabIndex = 0;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(6, 270);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(103, 17);
            this.labelSupplierName.TabIndex = 1;
            this.labelSupplierName.Text = "Supplier Name";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(115, 270);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(200, 22);
            this.textBoxSupplierName.TabIndex = 2;
            // 
            // labelItemsPurchased
            // 
            this.labelItemsPurchased.AutoSize = true;
            this.labelItemsPurchased.Location = new System.Drawing.Point(6, 310);
            this.labelItemsPurchased.Name = "labelItemsPurchased";
            this.labelItemsPurchased.Size = new System.Drawing.Size(113, 17);
            this.labelItemsPurchased.TabIndex = 3;
            this.labelItemsPurchased.Text = "Items Purchased";
            // 
            // textBoxItemsPurchased
            // 
            this.textBoxItemsPurchased.Location = new System.Drawing.Point(125, 310);
            this.textBoxItemsPurchased.Name = "textBoxItemsPurchased";
            this.textBoxItemsPurchased.Size = new System.Drawing.Size(200, 22);
            this.textBoxItemsPurchased.TabIndex = 4;
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.Location = new System.Drawing.Point(350, 270);
            this.buttonAddPurchase.Name = "buttonAddPurchase";
            this.buttonAddPurchase.Size = new System.Drawing.Size(100, 30);
            this.buttonAddPurchase.TabIndex = 5;
            this.buttonAddPurchase.Text = "Add Purchase";
            this.buttonAddPurchase.UseVisualStyleBackColor = true;
            this.buttonAddPurchase.Click += new System.EventHandler(this.buttonAddPurchase_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(756, 250);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(350, 270);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(100, 30);
            this.buttonAddCustomer.TabIndex = 5;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(350, 310);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdateCustomer.TabIndex = 6;
            this.buttonUpdateCustomer.Text = "Update Customer";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(350, 350);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteCustomer.TabIndex = 7;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(125, 270);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(6, 270);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(113, 17);
            this.labelCustomerName.TabIndex = 8;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // textBoxCustomerDetails
            // 
            this.textBoxCustomerDetails.Location = new System.Drawing.Point(125, 310);
            this.textBoxCustomerDetails.Name = "textBoxCustomerDetails";
            this.textBoxCustomerDetails.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerDetails.TabIndex = 2;
            // 
            // labelCustomerDetails
            // 
            this.labelCustomerDetails.AutoSize = true;
            this.labelCustomerDetails.Location = new System.Drawing.Point(6, 310);
            this.labelCustomerDetails.Name = "labelCustomerDetails";
            this.labelCustomerDetails.Size = new System.Drawing.Size(116, 17);
            this.labelCustomerDetails.TabIndex = 9;
            this.labelCustomerDetails.Text = "Customer Details";
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowHeadersWidth = 51;
            this.dataGridViewSuppliers.RowTemplate.Height = 24;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(756, 250);
            this.dataGridViewSuppliers.TabIndex = 0;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Location = new System.Drawing.Point(350, 270);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(100, 30);
            this.buttonAddSupplier.TabIndex = 5;
            this.buttonAddSupplier.Text = "Add Supplier";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // buttonUpdateSupplier
            // 
            this.buttonUpdateSupplier.Location = new System.Drawing.Point(350, 310);
            this.buttonUpdateSupplier.Name = "buttonUpdateSupplier";
            this.buttonUpdateSupplier.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdateSupplier.TabIndex = 6;
            this.buttonUpdateSupplier.Text = "Update Supplier";
            this.buttonUpdateSupplier.UseVisualStyleBackColor = true;
            this.buttonUpdateSupplier.Click += new System.EventHandler(this.buttonUpdateSupplier_Click);
            // 
            // buttonDeleteSupplier
            // 
            this.buttonDeleteSupplier.Location = new System.Drawing.Point(350, 350);
            this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            this.buttonDeleteSupplier.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteSupplier.TabIndex = 7;
            this.buttonDeleteSupplier.Text = "Delete Supplier";
            this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
            // 
            // textBoxSupplierDetails
            // 
            this.textBoxSupplierDetails.Location = new System.Drawing.Point(125, 310);
            this.textBoxSupplierDetails.Name = "textBoxSupplierDetails";
            this.textBoxSupplierDetails.Size = new System.Drawing.Size(200, 22);
            this.textBoxSupplierDetails.TabIndex = 2;
            // 
            // labelSupplierDetails
            // 
            this.labelSupplierDetails.AutoSize = true;
            this.labelSupplierDetails.Location = new System.Drawing.Point(6, 310);
            this.labelSupplierDetails.Name = "labelSupplierDetails";
            this.labelSupplierDetails.Size = new System.Drawing.Size(104, 17);
            this.labelSupplierDetails.TabIndex = 9;
            this.labelSupplierDetails.Text = "Supplier Details";
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlManagement);
            this.Name = "ManagementPage";
            this.Text = "Management";
            this.tabControlManagement.ResumeLayout(false);
            this.tabPagePurchases.ResumeLayout(false);
            this.tabPagePurchases.PerformLayout();
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            this.tabPageSuppliers.ResumeLayout(false);
            this.tabPageSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlManagement;
        private System.Windows.Forms.TabPage tabPagePurchases;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewPurchases;
        private System.Windows.Forms.Button buttonAddPurchase;
        private System.Windows.Forms.TextBox textBoxItemsPurchased;
        private System.Windows.Forms.Label labelItemsPurchased;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerDetails;
        private System.Windows.Forms.Label labelCustomerDetails;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonUpdateSupplier;
        private System.Windows.Forms.Button buttonDeleteSupplier;
        private System.Windows.Forms.TextBox textBoxSupplierDetails;
        private System.Windows.Forms.Label labelSupplierDetails;

        #endregion
    }
}
