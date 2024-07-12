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
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(286, 107);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(228, 37);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "HOŞ GELDİNİZ";
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.DarkOrange;
            this.btnItems.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Location = new System.Drawing.Point(439, 188);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(216, 135);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Ürünler";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStock.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(148, 188);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(216, 135);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stok";
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmMainMenu";
            this.Text = "Depo Envanter Yönetici - Ana menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnStock;
    }
}