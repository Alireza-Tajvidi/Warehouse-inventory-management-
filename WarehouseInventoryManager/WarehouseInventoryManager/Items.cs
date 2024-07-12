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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseInventoryManager
{
    public partial class Items : Form
    {

        SQLiteConnection connection;
        public Items()
        {
            InitializeComponent();
        }
        private void Items_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;");
            connection.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Items", connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter dbadapter = new SQLiteDataAdapter(comm);
            dbadapter.Fill(dt);

            dtgrdItems.DataSource = dt;
            connection.Close();
        }

        private void txtItemName_Enter(object sender, EventArgs e)
        {
            if (txtItemName.Text == "Ürün adı")
                txtItemName.Text = "";
            txtItemName.ForeColor = Color.Black;
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "Ürün fıyatı")
                txtPrice.Text = "";
            txtPrice.ForeColor = Color.Black;
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "Ürün kodu")
                txtCode.Text = "";
            txtCode.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "Ürün kodu";
            txtCode.ForeColor = Color.LightGray;
            txtPrice.Text = "Ürün fıyatı";
            txtPrice.ForeColor = Color.LightGray;
            txtItemName.Text = "Ürün adı";
            txtItemName.ForeColor = Color.LightGray;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != null && txtPrice.Text != null && txtCode.Text != null && txtItemName.Text != "Ürün adı" &&
              txtPrice.Text != "Ürün fıyatı" && txtCode.Text != "Ürün kodu")
                try
                {
                    connection.Open();
                    string query = "insert into Items(Urun_ad, Urun_fiyat, Urun_kod) values('" + this.txtItemName.Text + "'" +
                        ",'" + this.txtPrice.Text + "' ,'" + this.txtCode.Text + "')";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteReader();
                    connection.Close();
                    MessageBox.Show("Ürün eklendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            connection.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Items", connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter dbadapter = new SQLiteDataAdapter(comm);
            dbadapter.Fill(dt);

            dtgrdItems.DataSource = dt;
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Items WHERE Urun_kod = @SearchText";
            string searchText = txtCode.Text;
            connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SearchText", searchText);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        // Update other columns of the matching row
                        string updateQuery = "UPDATE Items SET Urun_ad = @New_ad, Urun_fiyat = @New_fiyat WHERE Id = @Id";
                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@New_ad", txtItemName.Text); // Example new value
                            updateCmd.Parameters.AddWithValue("@New_fiyat", txtPrice.Text); // Example new value
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteReader();
                            connection.Close();
                        }

                        connection.Open();
                        SQLiteCommand comm = new SQLiteCommand("Select * From Items", connection);
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter dbadapter = new SQLiteDataAdapter(comm);
                        dbadapter.Fill(dt);

                        dtgrdItems.DataSource = dt;
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Urun bulunmadı.");
                    }
                }
            }
            
        }
    }
}
