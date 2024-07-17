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
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
            PullItems();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string Item = cmbItem.Text;
            string Color = cmbColor.Text;

            string selectQuery = "SELECT * FROM Inventory WHERE Urun = @New_urun AND Renk = @New_renk";
            using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, conn))
            {
                selectCommand.Parameters.AddWithValue("@New_urun", Item);
                selectCommand.Parameters.AddWithValue("@New_renk", Color);

                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);  // Assuming the first column is the ID
                        int OldValue = reader.GetInt32(3);
                        int NewValue = OldValue + Convert.ToInt32(nmrAmount.Value);

                        string updateQuery = "UPDATE Inventory SET Miktar = @New_miktar WHERE id = @id";
                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, conn))
                        {
                            updateCommand.Parameters.AddWithValue("@New_miktar", NewValue.ToString()); 
                            updateCommand.Parameters.AddWithValue("@id", id);

                            updateCommand.ExecuteNonQuery();
                            conn.Close();
                            PullData();
                        }
                    }
                    else
                    {
                        reader.Close(); // Close the reader before inserting a new row
                        string insertQuery = "INSERT INTO Inventory (Urun, Renk, Miktar) VALUES (@Urun, @Renk, @Miktar)";
                        using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@Urun", Item);
                            insertCommand.Parameters.AddWithValue("@Renk", Color);
                            insertCommand.Parameters.AddWithValue("@Miktar", nmrAmount.Text);

                            insertCommand.ExecuteNonQuery();
                            conn.Close();
                            PullData();
                        }
                    }

                }
            }
        
    }


        private void btnTakeout_Click(object sender, EventArgs e)
        {

            conn.Open();

            string Item = cmbItem.Text;
            string Color = cmbColor.Text;

            string selectQuery = "SELECT * FROM Inventory WHERE Urun = @New_urun AND Renk = @New_renk";
            using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, conn))
            {
                selectCommand.Parameters.AddWithValue("@New_urun", Item);
                selectCommand.Parameters.AddWithValue("@New_renk", Color);

                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);  // Assuming the first column is the ID
                        int OldValue = reader.GetInt32(3);
                        int NewValue = OldValue - Convert.ToInt32(nmrAmount.Value) ;

                        if (NewValue < 0)
                        {
                            MessageBox.Show("Envanterde yeterli ürün bulunmadı");
                            conn.Close();
                        }
                        else
                        {
                            string updateQuery = "UPDATE Inventory SET Miktar = @New_miktar WHERE id = @id";
                            using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, conn))
                            {
                                updateCommand.Parameters.AddWithValue("@New_miktar", NewValue.ToString());
                                updateCommand.Parameters.AddWithValue("@id", id);

                                updateCommand.ExecuteNonQuery();
                                conn.Close();
                                PullData();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunmadı!");
                    }
                }
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Inventory WHERE Urun = @SearchItem AND Renk = @SearchColor";
            string SearchColor = cmbColor.Text;
            string SearchItem = cmbItem.Text;
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SearchItem", SearchItem);
                cmd.Parameters.AddWithValue("@SearchColor", SearchColor);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    //if an identical Urun_kod exists
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        // Update other columns of the matching row
                        string deleteQuery = "DELETE FROM Inventory WHERE Id = @Id";
                        using (SQLiteCommand updateCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteReader();
                           
                        }
                        conn.Close();
                        PullData();
                        
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Urun bulunmadı.");
                    }
                }
            }


        }
        private void dtgrdInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dtgrdInventory.Rows[e.RowIndex];

                    // Assuming columns: 0 = Id, 1 = Name, 2 = Age, 3 = Email
                    string ItemName = row.Cells[1].Value.ToString();
                    string Price = row.Cells[2].Value.ToString();
                    string Code = row.Cells[3].Value.ToString();

                    // Update text boxes with the values from the selected row
                    cmbItem.Text = ItemName;
                    cmbColor.Text = Price;
                }
            }
            conn.Close();
        }

        private void PullData()
        {

            conn.Open();

            string selectQuery = "SELECT * FROM [Inventory]";
            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, conn))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgrdInventory.DataSource = dataTable;
            }
            
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
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            this.Close();
            frmMainMenu.ShowDialog();
        }

        
    }
}
