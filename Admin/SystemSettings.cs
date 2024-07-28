using System;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Islington
{
    public partial class SystemSettings : Form
    {
        private SQLiteConnectionManager dbManager;

        public SystemSettings()
        {
            InitializeComponent();
            dbManager = new SQLiteConnectionManager("IslingtonDB.sqlite");
            LoadSettings();
        }

        private void LoadSettings()
        {
            string queryTaxRate = "SELECT Value FROM Settings WHERE Key = 'TaxRate'";
            string queryCurrency = "SELECT Value FROM Settings WHERE Key = 'Currency'";

            DataTable taxRateResult = dbManager.ExecuteQuery(queryTaxRate);
            DataTable currencyResult = dbManager.ExecuteQuery(queryCurrency);

            if (taxRateResult.Rows.Count > 0)
            {
                txtTaxRate.Text = taxRateResult.Rows[0]["Value"].ToString();
            }

            if (currencyResult.Rows.Count > 0)
            {
                cbCurrency.SelectedItem = currencyResult.Rows[0]["Value"].ToString();
            }
        }

        private void btnSaveTaxRate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTaxRate.Text, out decimal taxRate))
            {
                string query = $"UPDATE Settings SET Value='{taxRate}' WHERE Key='TaxRate'";
                if (dbManager.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Tax rate updated successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to update tax rate.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid tax rate.", "Validation Error");
            }
        }

        private void btnSaveCurrency_Click(object sender, EventArgs e)
        {
            if (cbCurrency.SelectedItem != null)
            {
                string currency = cbCurrency.SelectedItem.ToString();
                string query = $"UPDATE Settings SET Value='{currency}' WHERE Key='Currency'";
                if (dbManager.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Currency updated successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to update currency.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a currency.", "Validation Error");
            }
        }

        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQLite Database File (*.sqlite)|*.sqlite";
            saveFileDialog.Title = "Save Database Backup";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy("IslingtonDB.sqlite", saveFileDialog.FileName, true);
                    MessageBox.Show("Database backup created successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to create database backup. Error: {ex.Message}", "Error");
                }
            }
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite Database File (*.sqlite)|*.sqlite";
            openFileDialog.Title = "Select Database Backup to Restore";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(openFileDialog.FileName, "IslingtonDB.sqlite", true);
                    MessageBox.Show("Database restored successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to restore database. Error: {ex.Message}", "Error");
                }
            }
        }
    }
}
