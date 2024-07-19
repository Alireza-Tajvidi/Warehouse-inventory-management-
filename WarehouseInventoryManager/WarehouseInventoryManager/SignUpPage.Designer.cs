namespace WarehouseInventoryManager
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername_signup = new System.Windows.Forms.TextBox();
            this.lbUsername_signup = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.txtPassword_signup = new System.Windows.Forms.TextBox();
            this.lbPassword_signup = new System.Windows.Forms.Label();
            this.lbPasswordConfirm = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnMakeAccount = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbLastname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsername_signup
            // 
            this.txtUsername_signup.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername_signup.Location = new System.Drawing.Point(155, 106);
            this.txtUsername_signup.Name = "txtUsername_signup";
            this.txtUsername_signup.Size = new System.Drawing.Size(329, 26);
            this.txtUsername_signup.TabIndex = 4;
            // 
            // lbUsername_signup
            // 
            this.lbUsername_signup.AutoSize = true;
            this.lbUsername_signup.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername_signup.Location = new System.Drawing.Point(49, 111);
            this.lbUsername_signup.Name = "lbUsername_signup";
            this.lbUsername_signup.Size = new System.Drawing.Size(100, 21);
            this.lbUsername_signup.TabIndex = 3;
            this.lbUsername_signup.Text = "Kullanıcı adı:";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.Location = new System.Drawing.Point(224, 47);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(109, 34);
            this.lbSignUp.TabIndex = 3;
            this.lbSignUp.Text = "Kayıt ol!";
            // 
            // txtPassword_signup
            // 
            this.txtPassword_signup.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_signup.Location = new System.Drawing.Point(155, 226);
            this.txtPassword_signup.Name = "txtPassword_signup";
            this.txtPassword_signup.Size = new System.Drawing.Size(329, 26);
            this.txtPassword_signup.TabIndex = 6;
            // 
            // lbPassword_signup
            // 
            this.lbPassword_signup.AutoSize = true;
            this.lbPassword_signup.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword_signup.Location = new System.Drawing.Point(104, 231);
            this.lbPassword_signup.Name = "lbPassword_signup";
            this.lbPassword_signup.Size = new System.Drawing.Size(45, 21);
            this.lbPassword_signup.TabIndex = 5;
            this.lbPassword_signup.Text = "Şifre:";
            // 
            // lbPasswordConfirm
            // 
            this.lbPasswordConfirm.AutoSize = true;
            this.lbPasswordConfirm.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordConfirm.Location = new System.Drawing.Point(46, 272);
            this.lbPasswordConfirm.Name = "lbPasswordConfirm";
            this.lbPasswordConfirm.Size = new System.Drawing.Size(103, 21);
            this.lbPasswordConfirm.TabIndex = 5;
            this.lbPasswordConfirm.Text = "Şifre (Tekrar):";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(155, 267);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(329, 26);
            this.txtPasswordConfirm.TabIndex = 6;
            // 
            // btnMakeAccount
            // 
            this.btnMakeAccount.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMakeAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeAccount.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAccount.Location = new System.Drawing.Point(371, 310);
            this.btnMakeAccount.Name = "btnMakeAccount";
            this.btnMakeAccount.Size = new System.Drawing.Size(113, 29);
            this.btnMakeAccount.TabIndex = 7;
            this.btnMakeAccount.Text = "Hesap oluştur";
            this.btnMakeAccount.UseVisualStyleBackColor = false;
            this.btnMakeAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(116, 149);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(33, 21);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Ad:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(155, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(329, 26);
            this.txtName.TabIndex = 4;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastname.Location = new System.Drawing.Point(93, 184);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(56, 21);
            this.lbLastname.TabIndex = 3;
            this.lbLastname.Text = "Soyad:";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(155, 184);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(329, 26);
            this.txtLastname.TabIndex = 4;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.btnMakeAccount);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.lbPasswordConfirm);
            this.Controls.Add(this.txtPassword_signup);
            this.Controls.Add(this.lbPassword_signup);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.txtUsername_signup);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.lbUsername_signup);
            this.Name = "frmSignUp";
            this.Text = "SignUpPage";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername_signup;
        private System.Windows.Forms.Label lbUsername_signup;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.TextBox txtPassword_signup;
        private System.Windows.Forms.Label lbPassword_signup;
        private System.Windows.Forms.Label lbPasswordConfirm;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Button btnMakeAccount;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.TextBox txtLastname;
    }
}