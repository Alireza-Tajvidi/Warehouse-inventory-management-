using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace WarehouseInventoryManager
{
    internal class DatasynceCloudToLocal
    {
        private string sqliteConnectionString = @"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;";
        private FirebaseClient firebaseClient;

        public DatasynceCloudToLocal()
        {
            // Initialize Firebase client
            firebaseClient = new FirebaseClient("https://depo-envanter-default-rtdb.firebaseio.com/");
        }

        public async Task ReplaceSQLiteDataAsync(string firebaseTableName, string sqliteTableName)
        {
            // Retrieve data from Firebase
            var firebaseData = await GetFirebaseDataAsync(firebaseTableName);

            // Replace data in SQLite
            ReplaceDataInSQLite(firebaseData, sqliteTableName);
        }

        private async Task<DataTable> GetFirebaseDataAsync(string tableName)
        {
            var firebaseData = await firebaseClient
                .Child(tableName)
                .OnceAsync<Dictionary<string, string>>();

            DataTable dataTable = new DataTable();

            if (firebaseData.Count > 0)
            {
                // Create columns in DataTable
                foreach (var column in firebaseData.First().Object.Keys)
                {
                    dataTable.Columns.Add(column);
                }

                // Add rows to DataTable
                foreach (var item in firebaseData)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (var column in item.Object.Keys)
                    {
                        row[column] = item.Object[column];
                    }
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        private void ReplaceDataInSQLite(DataTable firebaseData, string tableName)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    // Clear existing data in the table
                    string deleteQuery = $"DELETE FROM {tableName}";
                    using (var deleteCommand = new SQLiteCommand(deleteQuery, connection))
                    {
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Insert new data from DataTable
                    foreach (DataRow row in firebaseData.Rows)
                    {
                        var columns = string.Join(", ", row.Table.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                        var values = string.Join(", ", row.ItemArray.Select(value => $"'{value}'"));
                        string insertQuery = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
                        using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                        {
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }
        }
    }
}
