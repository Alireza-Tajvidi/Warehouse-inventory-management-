namespace WarehouseInventoryManager
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.dtgrdInventory = new System.Windows.Forms.DataGridView();
            this.lbItem = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTakeout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdInventory
            // 
            this.dtgrdInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdInventory.Location = new System.Drawing.Point(12, 162);
            this.dtgrdInventory.Name = "dtgrdInventory";
            this.dtgrdInventory.Size = new System.Drawing.Size(908, 428);
            this.dtgrdInventory.TabIndex = 0;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(12, 61);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(43, 21);
            this.lbItem.TabIndex = 1;
            this.lbItem.Text = "Ürün";
            // 
            // cmbItem
            // 
            this.cmbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(12, 85);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(381, 28);
            this.cmbItem.TabIndex = 2;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(395, 62);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(46, 21);
            this.lbColor.TabIndex = 1;
            this.lbColor.Text = "Renk";
            // 
            // cmbColor
            // 
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Siyah",
            "Beyaz",
            "Mavi",
            "Kırmızı",
            "Yeşil",
            "Sarı"});
            this.cmbColor.Location = new System.Drawing.Point(399, 85);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(331, 28);
            this.cmbColor.TabIndex = 2;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(732, 62);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(55, 21);
            this.lbAmount.TabIndex = 1;
            this.lbAmount.Text = "Miktar";
            // 
            // nmrAmount
            // 
            this.nmrAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrAmount.Location = new System.Drawing.Point(736, 86);
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(184, 26);
            this.nmrAmount.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Location = new System.Drawing.Point(12, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(355, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTakeout
            // 
            this.btnTakeout.BackColor = System.Drawing.Color.Khaki;
            this.btnTakeout.Location = new System.Drawing.Point(373, 116);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Size = new System.Drawing.Size(329, 37);
            this.btnTakeout.TabIndex = 4;
            this.btnTakeout.Text = "Çıkart";
            this.btnTakeout.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(708, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picBack
            // 
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(12, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(33, 37);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 5;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 602);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTakeout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nmrAmount);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.dtgrdInventory);
            this.Name = "frmInventory";
            this.Text = "Envanter";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdInventory;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTakeout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picBack;
    }
}