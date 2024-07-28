namespace Islington
{
    partial class SalesBilling
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
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerContact = new System.Windows.Forms.Label();
            this.textBoxCustomerContact = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.buttonEditInvoice = new System.Windows.Forms.Button();
            this.buttonDeleteInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(30, 30);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(110, 17);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(150, 30);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // labelCustomerContact
            // 
            this.labelCustomerContact.AutoSize = true;
            this.labelCustomerContact.Location = new System.Drawing.Point(30, 70);
            this.labelCustomerContact.Name = "labelCustomerContact";
            this.labelCustomerContact.Size = new System.Drawing.Size(122, 17);
            this.labelCustomerContact.TabIndex = 2;
            this.labelCustomerContact.Text = "Customer Contact";
            // 
            // textBoxCustomerContact
            // 
            this.textBoxCustomerContact.Location = new System.Drawing.Point(150, 70);
            this.textBoxCustomerContact.Name = "textBoxCustomerContact";
            this.textBoxCustomerContact.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerContact.TabIndex = 3;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(30, 110);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(57, 17);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Product";
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(150, 110);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(200, 22);
            this.textBoxProduct.TabIndex = 5;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(30, 150);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 17);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(150, 150);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(200, 22);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(30, 190);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(150, 190);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 22);
            this.textBoxPrice.TabIndex = 9;
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.Location = new System.Drawing.Point(150, 230);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(100, 30);
            this.buttonAddInvoice.TabIndex = 10;
            this.buttonAddInvoice.Text = "Add Invoice";
            this.buttonAddInvoice.UseVisualStyleBackColor = true;
            this.buttonAddInvoice.Click += new System.EventHandler(this.buttonAddInvoice_Click);
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(30, 280);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowHeadersWidth = 51;
            this.dataGridViewInvoices.RowTemplate.Height = 24;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewInvoices.TabIndex = 11;
            // 
            // buttonEditInvoice
            // 
            this.buttonEditInvoice.Location = new System.Drawing.Point(350, 230);
            this.buttonEditInvoice.Name = "buttonEditInvoice";
            this.buttonEditInvoice.Size = new System.Drawing.Size(100, 30);
            this.buttonEditInvoice.TabIndex = 12;
            this.buttonEditInvoice.Text = "Edit Invoice";
            this.buttonEditInvoice.UseVisualStyleBackColor = true;
            this.buttonEditInvoice.Click += new System.EventHandler(this.buttonEditInvoice_Click);
            // 
            // buttonDeleteInvoice
            // 
            this.buttonDeleteInvoice.Location = new System.Drawing.Point(470, 230);
            this.buttonDeleteInvoice.Name = "buttonDeleteInvoice";
            this.buttonDeleteInvoice.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteInvoice.TabIndex = 13;
            this.buttonDeleteInvoice.Text = "Delete Invoice";
            this.buttonDeleteInvoice.UseVisualStyleBackColor = true;
            this.buttonDeleteInvoice.Click += new System.EventHandler(this.buttonDeleteInvoice_Click);
            // 
            // SalesBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteInvoice);
            this.Controls.Add(this.buttonEditInvoice);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.buttonAddInvoice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxCustomerContact);
            this.Controls.Add(this.labelCustomerContact);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Name = "SalesBilling";
            this.Text = "Sales and Billing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerContact;
        private System.Windows.Forms.TextBox textBoxCustomerContact;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddInvoice;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button buttonEditInvoice;
        private System.Windows.Forms.Button buttonDeleteInvoice;

        #endregion
    }
}
