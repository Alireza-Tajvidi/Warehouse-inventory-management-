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

        private void frmOrder_Load(object sender, EventArgs e)
        {
            PullData();
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
            SQLiteCommand comm = new SQLiteCommand("Select * From Inventory", conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter dbadapter = new SQLiteDataAdapter(comm);
            dbadapter.Fill(dt);

            dtgrdOrders.DataSource = dt;
            conn.Close();
        }
    }
}
