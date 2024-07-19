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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSignUp_Load);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // stablishes conection to the data base
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Inventory.sqlite;Version=3;New=True;Compress=True;");
            if (txtPassword_signup.Text == txtPasswordConfirm.Text)
            {
                try
                {
                    //adds new users
                    conn.Open();
                    string query = "insert into kullaniciKayit(kullanici_adi, sifre, ad,soyad) values('" + this.txtUsername_signup.Text + "'" +
                        ",'" + this.txtPassword_signup.Text + "','" + this.txtName.Text + "','" + this.txtLastname.Text + "')";
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
            //shows error if the password repeat is incorrect
            else 
            {
                MessageBox.Show("Sifre tekrar yanliş");
            }

            var dataSyncLtC = new DatasyncLocalToCloud();
            await dataSyncLtC.ReplaceFirebaseDataAsync("kullaniciKayit", "kullaniciKayit");

        }

        private async void frmSignUp_Load(object sender, EventArgs e)
        {
            var dataSyncCtL = new DatasynceCloudToLocal();
            await dataSyncCtL.ReplaceSQLiteDataAsync("kullaniciKayit", "kullaniciKayit");
        }
    }
}
