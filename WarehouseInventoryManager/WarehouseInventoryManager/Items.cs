using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Items()
        {
            InitializeComponent();
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
    }
}
