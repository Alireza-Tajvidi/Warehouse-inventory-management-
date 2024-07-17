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
        public string User_name { get; set; }
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
                // login successful, go to menu and close login page
                MessageBox.Show("Giriş yapıldı!");
                frmMainMenu mainMenu = new frmMainMenu();
                mainMenu.Show();
                this.Hide();
                frmLogin Loginpage = new frmLogin();

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
            //controls login information username
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
                    // checks if password and user name match
                    if (storedPassword == password)
                    {
                        User_name = reader ["Ad"].ToString() + " " + reader["Soyad"].ToString();
                        isValid = true;
                    }
                }
            }
            //catches exceptions
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
        //opens sign up page
        private void lbSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp signUpPage = new frmSignUp();
            signUpPage.Show();
        }
    }
}