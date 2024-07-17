namespace WarehouseInventoryManager
{
    partial class frmMainMenu
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbWelcome_user = new System.Windows.Forms.Label();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(286, 24);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(228, 37);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "HOŞ GELDİNİZ";
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.DarkOrange;
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItems.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Location = new System.Drawing.Point(430, 133);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(216, 135);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Stok";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(298, 274);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(216, 135);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Siparişler";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbWelcome_user
            // 
            this.lbWelcome_user.AutoSize = true;
            this.lbWelcome_user.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome_user.Location = new System.Drawing.Point(354, 61);
            this.lbWelcome_user.Name = "lbWelcome_user";
            this.lbWelcome_user.Size = new System.Drawing.Size(71, 37);
            this.lbWelcome_user.TabIndex = 0;
            this.lbWelcome_user.Text = "      ";
            // 
            // BtnInventory
            // 
            this.BtnInventory.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventory.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventory.Location = new System.Drawing.Point(182, 133);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(216, 135);
            this.BtnInventory.TabIndex = 1;
            this.BtnInventory.Text = "Envanter";
            this.BtnInventory.UseVisualStyleBackColor = false;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.lbWelcome_user);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmMainMenu";
            this.Text = "Depo Envanter Yönetici - Ana menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbWelcome_user;
        private System.Windows.Forms.Button BtnInventory;
    }
}