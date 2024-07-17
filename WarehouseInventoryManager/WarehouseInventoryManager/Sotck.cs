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
    public partial class frmStock : Form
    {

        SQLiteConnection connection;
        public frmStock()
        {
            InitializeComponent();
        }
        private void Items_Load(object sender, EventArgs e)
        {
            //pull data from database and display in data grid view tool
            connection = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;");
            PullData();
        }
        // removes placeholder from textbox
        private void txtItemName_Enter(object sender, EventArgs e)
        {
            if (txtItemName.Text == "Ürün adı")
                txtItemName.Text = "";
            txtItemName.ForeColor = Color.Black;
        }
        // removes placeholder from textbox
        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "Ürün fıyatı")
                txtPrice.Text = "";
            txtPrice.ForeColor = Color.Black;
        }
        // removes placeholder from textbox
        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "Ürün kodu")
                txtCode.Text = "";
            txtCode.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           Clear();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //gives condition of textboxes not being empty or having the placeholder in them
            if (txtItemName.Text != null && txtPrice.Text != null && txtCode.Text != null && txtItemName.Text != "Ürün adı" &&
              txtPrice.Text != "Ürün fıyatı" && txtCode.Text != "Ürün kodu")
                // tries to add text box values into table
                try
                {
                    connection.Open();
                    string query = "insert into Stock(Urun_ad, Urun_fiyat, Urun_kod) values('" + this.txtItemName.Text + "'" +
                        ",'" + this.txtPrice.Text + "' ,'" + this.txtCode.Text + "')";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteReader();
                    connection.Close();
                    MessageBox.Show("Ürün eklendi");
                }
                //catches exceptions
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            PullData();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //searches for row in data base with the entered barcode
            string query = "SELECT * FROM Stock WHERE Urun_kod = @SearchText";
            string searchText = txtCode.Text;
            connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SearchText", searchText);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    //if an identical Urun_kod exists
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        // Update other columns of the matching row
                        string updateQuery = "UPDATE Stock SET Urun_ad = @New_ad, Urun_fiyat = @New_fiyat, Urun_kod = @New_kod WHERE Id = @Id";
                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@New_ad", txtItemName.Text); 
                            updateCmd.Parameters.AddWithValue("@New_fiyat", txtPrice.Text);
                            updateCmd.Parameters.AddWithValue("@New_kod", txtCode.Text);
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteReader();
                            connection.Close();
                        }

                        PullData();
                        Clear();
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Urun bulunmadı.");
                    }
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //searches for row in data base with the entered barcode
            string query = "SELECT * FROM Stock WHERE Urun_kod = @SearchText";
            string searchText = txtCode.Text;
            connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SearchText", searchText);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    //if an identical Urun_kod exists
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        // Update other columns of the matching row
                        string deleteQuery = "DELETE FROM Stock WHERE Id = @Id";
                        using (SQLiteCommand updateCmd = new SQLiteCommand(deleteQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteReader();
                            connection.Close();
                        }

                        PullData();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Urun bulunmadı.");
                    }
                }
            }
        }
        private void dtgrdItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string searchText = txtCode.Text;

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dtgrdItems.Rows[e.RowIndex];

                    // Assuming columns: 0 = Id, 1 = Name, 2 = Age, 3 = Email
                    string ItemName = row.Cells[1].Value.ToString();
                    string Price = row.Cells[2].Value.ToString();
                    string Code = row.Cells[3].Value.ToString();

                      txtItemName.ForeColor = Color.Black;
                      txtPrice.ForeColor = Color.Black;
                      txtCode.ForeColor = Color.Black;
                      
                    // Update text boxes with the values from the selected row
                    txtItemName.Text = ItemName;
                    txtPrice.Text = Price;
                    txtCode.Text = Code;
                }
            }
        }

        //removes input from text boxes and replaces them with place holders
        private void Clear()
        {
            txtCode.Text = "Ürün kodu";
            txtCode.ForeColor = Color.LightGray;
            txtPrice.Text = "Ürün fıyatı";
            txtPrice.ForeColor = Color.LightGray;
            txtItemName.Text = "Ürün adı";
            txtItemName.ForeColor = Color.LightGray;
        }

        // pulls data from data base
        private void PullData()
        {
            connection.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Stock", connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter dbadapter = new SQLiteDataAdapter(comm);
            dbadapter.Fill(dt);

            dtgrdItems.DataSource = dt;
            connection.Close();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            this.Close();
            frmMainMenu.ShowDialog();
        }
    }
}