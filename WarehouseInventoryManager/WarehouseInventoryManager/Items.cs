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
            SQLiteCommand comm = new SQLiteCommand("Select * From ", connection);
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
            txtItemName.ForeColor= Color.LightGray;
        }
    }
}
