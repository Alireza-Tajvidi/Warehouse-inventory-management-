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
    public partial class frmLogin : Form
    {
        SQLiteConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(@"Data Source=C:\Users\parsa\Desktop\Depo Envanter yonetici\Database\Users.sqlite;Version=3;New=True;Compress=True;");
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            if (CheckLogin(username, password))
            {
                MessageBox.Show("Giriş yapıldı!");
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                // login successful, do something
                
                this.Hide();
                frmLogin Loginpage = new frmLogin();
                //For when connected to main menu
                // MainForm mainForm = new MainForm();
                // mainForm.ShowDialog();
                Loginpage.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre.");
            }
        }

        private bool CheckLogin(string username, string password)
        {
            bool isValid = false;

            try
            {
                conn.Open();

                string query = "SELECT * FROM User WHERE Username = @username";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedPassword = reader["Password"].ToString();

                    if (storedPassword == password)
                    {
                        isValid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isValid;
        }
        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
        }
    }

 
}


