using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseInventoryManager
{
    public partial class frmInventory : Form
    {
        SQLiteConnection conn;
        public frmInventory()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;");
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            PullData();

        }



        private void PullData()
        {
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Inventory", conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter dbadapter = new SQLiteDataAdapter(comm);
            dbadapter.Fill(dt);

            dtgrdInventory.DataSource = dt;
            conn.Close();
        }

        private void PullItems()
        {
            string query = "SELECT Urun_ad FROM Stock";
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbItem.Items.Add(reader["Urun_ad"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
