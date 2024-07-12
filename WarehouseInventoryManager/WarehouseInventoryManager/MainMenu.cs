using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnItems_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Close();
        }
    }
}
