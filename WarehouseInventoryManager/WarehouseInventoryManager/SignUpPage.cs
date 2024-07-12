using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SQLite;
using System.Data.SQLite.Generic;

namespace WarehouseInventoryManager
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Users.sqlite;Version=3;New=True;Compress=True;");
            if (txtPassword_signup.Text == txtPasswordConfirm.Text)
            {
                try
                {
                    conn.Open();
                    string query = "insert into User(Username, Password) values('" + this.txtUsername_signup.Text + "'" +
                        ",'" + this.txtPassword_signup.Text + "')";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Bize katıldınız");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Sifre tekrar yanliş");
            }
        }
    }
}
