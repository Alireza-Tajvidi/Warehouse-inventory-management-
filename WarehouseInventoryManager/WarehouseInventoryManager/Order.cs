using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WarehouseInventoryManager
{
    public partial class frmOrder : Form
    {
        SQLiteConnection conn;
        public frmOrder()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;");

        }

        private async void frmOrder_Load(object sender, EventArgs e)
        {
            PullData();
            PullItems();
            var dataSyncCtL = new DatasynceCloudToLocal();
            await dataSyncCtL.ReplaceSQLiteDataAsync("siparisler", "siparisler");
        }

        private async void btnAdd_order_Click(object sender, EventArgs e)
        {
            //this code part had issues, keeping it for helping fix further problems
            { /*
                conn.Open();
                string maxIdQuery = "SELECT IFNULL (MAX(id), 0) FROM Order";
                using (SQLiteCommand maxIdCommand = new SQLiteCommand(maxIdQuery, conn))
                {
                    int maxId = Convert.ToInt32(maxIdCommand.ExecuteScalar());
                    int newId = maxId + 1;

                    // Step 2: Calculate new values
                    int columnToUpdateValue = newId + 1000;

                    try
                    {

                        string query = "insert into Order(Siparis_nu, Musteri_adi, Urun, Miktar, Durum) values('" + newId.ToString() + "''" + this.txtCustomer.Text + "'" +
                            ",'" + this.cmbItem.Text + "' ,'" + this.nmrAmount.Text + "', Gönderildi)";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.ExecuteReader();
                        conn.Close();
                        MessageBox.Show("Ürün eklendi");
                    }
                    //catches exceptions
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }*/
            }


            string Item = cmbItem.Text;
            string Color = cmbColor.Text;

            string selectQuery = "SELECT * FROM Inventory WHERE Urun = @New_urun AND Renk = @New_renk";

            try
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, conn, transaction))
                    {
                        selectCommand.Parameters.AddWithValue("@New_urun", Item);
                        selectCommand.Parameters.AddWithValue("@New_renk", Color);

                        using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);  // Assuming the first column is the ID
                                int OldValue = reader.GetInt32(3);
                                int NewValue = OldValue - Convert.ToInt32(nmrAmount.Value);

                                if (NewValue < 0)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Envanterde yeterli ürün bulunmadı");
                                    return;
                                }
                                else
                                {
                                    // Generate new order ID
                                    // string maxIdQuery = "SELECT IFNULL(MAX(musteri), 0) FROM siparisler";
                                    using (SQLiteCommand maxIdCommand = new SQLiteCommand( conn))
                                    {
                                     //  int maxId = Convert.ToInt32(maxIdCommand.ExecuteScalar());
                                     //  int newId = maxId + 1 + 1000;

                                        // Insert new order
                                        string insertQuery = "INSERT INTO  siparisler ( musteri, urun, miktar, durum) " +
                                                             "VALUES (@Musteri_adi, @Urun, @Miktar, @Durum)";
                                        using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@Musteri_adi", this.txtCustomer.Text);
                                            cmd.Parameters.AddWithValue("@Urun", this.cmbItem.Text);
                                            cmd.Parameters.AddWithValue("@Miktar", this.nmrAmount.Value);
                                            cmd.Parameters.AddWithValue("@Durum", "Gönderildi");

                                            cmd.ExecuteNonQuery();
                                        }

                                        // Update inventory
                                        string updateQuery = "UPDATE Inventory SET Miktar = @New_miktar WHERE id = @id";
                                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, conn, transaction))
                                        {
                                            updateCommand.Parameters.AddWithValue("@New_miktar", NewValue);
                                            updateCommand.Parameters.AddWithValue("@id", id);

                                            updateCommand.ExecuteNonQuery();
                                        }

                                        // Commit the transaction
                                        transaction.Commit();
                                        MessageBox.Show("Sipariş Oluşturuldu ve Envanter güncellendi!");
                                        var dataSyncLtC = new DatasyncLocalToCloud();
                                        await dataSyncLtC.ReplaceFirebaseDataAsync("siparisler", "siparisler");
                                    }
                                }
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Ürün bulunmadı!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    PullData();
                }
            }


        }

       private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM siparisler WHERE siparis_nu = @SearchText";
            string searchText = txtOrderNo.Text;

            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", searchText);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // if an identical Siparis_nu exists
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            // Update other columns of the matching row
                            string updateQuery = "UPDATE siparisler SET durum = @New_durum WHERE Id = @Id";
                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@New_durum", cmbState.Text); // Corrected parameter name case
                                updateCmd.Parameters.AddWithValue("@Id", id);
                                updateCmd.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Durum güncellendi!");
                            PullData();
                            var dataSyncLtC = new DatasyncLocalToCloud();
                            await dataSyncLtC.ReplaceFirebaseDataAsync("[Order]", "siparisler");
                        }
                        else
                        {
                            conn.Close() ;
                            MessageBox.Show("Sipariş bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dtgrdOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dtgrdOrders.Rows[e.RowIndex];

                    // Assuming columns: 0 = Id, 1 = Name, 2 = Age, 3 = Email
                    string OrderNo = row.Cells[1].Value.ToString();

                    // Update text boxes with the values from the selected row
                    txtOrderNo.Text = OrderNo; 
                }
            }
            conn.Close();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            this.Close();
            frmMainMenu.ShowDialog();
        }
       
        private void PullData()
        {
            conn.Open();

            string selectQuery = "SELECT * FROM siparisler";
            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, conn))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgrdOrders.DataSource = dataTable;
            }
            conn.Close();
        }
        private void PullItems()
        {
            string query = "SELECT DISTINCT Urun FROM Inventory";

                try
                {
                conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbItem.Items.Add(reader["Urun"].ToString());
                            }
                        }
                    }
                conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Renk FROM Inventory WHERE Urun = @SearchText";
            string Searchtext = cmbItem.Text;
            cmbColor.Items.Clear();

                try
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@SearchText", Searchtext);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbColor.Items.Add(reader["Renk"].ToString());
                            }
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);

                }
            
        }

       
    }
}
