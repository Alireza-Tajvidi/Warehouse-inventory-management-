using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Firebase.Database;
using Firebase.Database.Query;


namespace WarehouseInventoryManager
{
    internal class DatasyncLocalToCloud
    {
        private string sqliteConnectionString = @"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;";
        private FirebaseClient firebaseClient;

        public DatasyncLocalToCloud()
        {
            // Initialize Firebase client
            firebaseClient = new FirebaseClient("https://yourfirebaseapp.firebaseio.com/");
        }

        public async Task ReplaceFirebaseDataAsync(string sqliteTableName, string firebaseTableName)
        {
            // Retrieve data from SQLite
            var sqliteData = GetSQLiteData(sqliteTableName);

            // Replace data in Firebase
            await ReplaceDataInFirebaseAsync(sqliteData, firebaseTableName);
        }

        private DataTable GetSQLiteData(string tableName)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                using (var command = new SQLiteCommand(query, connection))
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private async Task ReplaceDataInFirebaseAsync(DataTable sqliteData, string firebaseTableName)
        {
            // Remove the existing data
            await firebaseClient.Child(firebaseTableName).DeleteAsync();

            // Insert new data
            foreach (DataRow row in sqliteData.Rows)
            {
                var dataDict = row.Table.Columns.Cast<DataColumn>().ToDictionary(col => col.ColumnName, col => row[col].ToString());
                await firebaseClient.Child(firebaseTableName).PostAsync(dataDict);
            }
        }
    }
}
