using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseInventoryManager
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //opens the items menu
        private void btnItems_Click(object sender, EventArgs e)
        {
            frmStock items = new frmStock();
            items.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Show();
            this.Close();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
            this.Close();
        }
    }
}