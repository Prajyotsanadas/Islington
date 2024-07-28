using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Islington
{
    public class SQLiteConnectionManager
    {
        private string databaseFile;
        private string connectionString;

        public SQLiteConnectionManager(string databaseFile)
        {
            this.databaseFile = databaseFile;
            connectionString = $"Data Source={databaseFile};Version=3;";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                string createUsersTable = @"CREATE TABLE IF NOT EXISTS Users (
                                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                FullName TEXT NOT NULL,
                                                Email TEXT NOT NULL UNIQUE,
                                                PhoneNumber TEXT NOT NULL,
                                                Password TEXT NOT NULL
                                            );";
                ExecuteNonQuery(createUsersTable);

                string createSettingsTable = @"CREATE TABLE IF NOT EXISTS Settings (
                                                Key TEXT PRIMARY KEY,
                                                Value TEXT NOT NULL
                                            );";
                ExecuteNonQuery(createSettingsTable);

                string createAuditLogsTable = @"CREATE TABLE IF NOT EXISTS AuditLogs (
                                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                                                Action TEXT NOT NULL,
                                                UserEmail TEXT,
                                                Description TEXT
                                            );";
                ExecuteNonQuery(createAuditLogsTable);

                // Initialize default settings if they don't exist
                InitializeDefaultSettings();
            }
        }

        private void InitializeDefaultSettings()
        {
            string checkTaxRate = "SELECT COUNT(*) FROM Settings WHERE Key = 'TaxRate';";
            string checkCurrency = "SELECT COUNT(*) FROM Settings WHERE Key = 'Currency';";

            if (ExecuteScalar(checkTaxRate) == 0)
            {
                string insertDefaultTaxRate = "INSERT INTO Settings (Key, Value) VALUES ('TaxRate', '0');";
                ExecuteNonQuery(insertDefaultTaxRate);
            }

            if (ExecuteScalar(checkCurrency) == 0)
            {
                string insertDefaultCurrency = "INSERT INTO Settings (Key, Value) VALUES ('Currency', 'USD');";
                ExecuteNonQuery(insertDefaultCurrency);
            }
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable(); // Return an empty DataTable instead of null
            }
        }

        public bool ExecuteNonQuery(string query)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public int ExecuteScalar(string query)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void LogAction(string action, string userEmail, string description)
        {
            string query = $"INSERT INTO AuditLogs (Action, UserEmail, Description) VALUES ('{action}', '{userEmail}', '{description}')";
            ExecuteNonQuery(query);
        }
    }
}
 