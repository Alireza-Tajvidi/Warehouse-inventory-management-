namespace WarehouseInventoryManager
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.dtgrdOrders = new System.Windows.Forms.DataGridView();
            this.grpbxNew_order = new System.Windows.Forms.GroupBox();
            this.btnAdd_order = new System.Windows.Forms.Button();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lbCostumer_name = new System.Windows.Forms.Label();
            this.grpbxOrder_update = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbOrderNo = new System.Windows.Forms.Label();
            this.panPanel = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdOrders)).BeginInit();
            this.grpbxNew_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            this.grpbxOrder_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdOrders
            // 
            this.dtgrdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdOrders.Location = new System.Drawing.Point(12, 41);
            this.dtgrdOrders.Name = "dtgrdOrders";
            this.dtgrdOrders.Size = new System.Drawing.Size(653, 549);
            this.dtgrdOrders.TabIndex = 0;
            this.dtgrdOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdOrders_CellDoubleClick);
            // 
            // grpbxNew_order
            // 
            this.grpbxNew_order.Controls.Add(this.btnAdd_order);
            this.grpbxNew_order.Controls.Add(this.nmrAmount);
            this.grpbxNew_order.Controls.Add(this.lbNumber);
            this.grpbxNew_order.Controls.Add(this.lbColor);
            this.grpbxNew_order.Controls.Add(this.cmbColor);
            this.grpbxNew_order.Controls.Add(this.cmbItem);
            this.grpbxNew_order.Controls.Add(this.lbItem);
            this.grpbxNew_order.Controls.Add(this.txtCustomer);
            this.grpbxNew_order.Controls.Add(this.lbCostumer_name);
            this.grpbxNew_order.Location = new System.Drawing.Point(671, 55);
            this.grpbxNew_order.Name = "grpbxNew_order";
            this.grpbxNew_order.Size = new System.Drawing.Size(249, 290);
            this.grpbxNew_order.TabIndex = 1;
            this.grpbxNew_order.TabStop = false;
            this.grpbxNew_order.Text = "Yeni sipariş";
            // 
            // btnAdd_order
            // 
            this.btnAdd_order.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd_order.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_order.Location = new System.Drawing.Point(10, 243);
            this.btnAdd_order.Name = "btnAdd_order";
            this.btnAdd_order.Size = new System.Drawing.Size(233, 31);
            this.btnAdd_order.TabIndex = 4;
            this.btnAdd_order.Text = "Sipariş ekle";
            this.btnAdd_order.UseVisualStyleBackColor = false;
            this.btnAdd_order.Click += new System.EventHandler(this.btnAdd_order_Click);
            // 
            // nmrAmount
            // 
            this.nmrAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrAmount.Location = new System.Drawing.Point(11, 208);
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(233, 26);
            this.nmrAmount.TabIndex = 3;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(7, 185);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(55, 20);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.Text = "Miktar:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(7, 128);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(47, 20);
            this.lbColor.TabIndex = 0;
            this.lbColor.Text = "Renk:";
            // 
            // cmbColor
            // 
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(10, 151);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(233, 28);
            this.cmbColor.TabIndex = 2;
            // 
            // cmbItem
            // 
            this.cmbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(10, 97);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(233, 28);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(6, 73);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(43, 20);
            this.lbItem.TabIndex = 0;
            this.lbItem.Text = "Ürün:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(10, 40);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(233, 26);
            this.txtCustomer.TabIndex = 1;
            // 
            // lbCostumer_name
            // 
            this.lbCostumer_name.AutoSize = true;
            this.lbCostumer_name.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostumer_name.Location = new System.Drawing.Point(6, 16);
            this.lbCostumer_name.Name = "lbCostumer_name";
            this.lbCostumer_name.Size = new System.Drawing.Size(86, 20);
            this.lbCostumer_name.TabIndex = 0;
            this.lbCostumer_name.Text = "Müşteri adı:";
            // 
            // grpbxOrder_update
            // 
            this.grpbxOrder_update.Controls.Add(this.btnUpdate);
            this.grpbxOrder_update.Controls.Add(this.cmbState);
            this.grpbxOrder_update.Controls.Add(this.txtOrderNo);
            this.grpbxOrder_update.Controls.Add(this.lbState);
            this.grpbxOrder_update.Controls.Add(this.lbOrderNo);
            this.grpbxOrder_update.Location = new System.Drawing.Point(671, 369);
            this.grpbxOrder_update.Name = "grpbxOrder_update";
            this.grpbxOrder_update.Size = new System.Drawing.Size(249, 210);
            this.grpbxOrder_update.TabIndex = 1;
            this.grpbxOrder_update.TabStop = false;
            this.grpbxOrder_update.Text = "Sipariş güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(11, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sipariş Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Gönderildi",
            "Teslim Edildi"});
            this.cmbState.Location = new System.Drawing.Point(10, 132);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(233, 28);
            this.cmbState.TabIndex = 2;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Location = new System.Drawing.Point(10, 68);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(233, 26);
            this.txtOrderNo.TabIndex = 1;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(6, 109);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(56, 20);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "Durum:";
            // 
            // lbOrderNo
            // 
            this.lbOrderNo.AutoSize = true;
            this.lbOrderNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderNo.Location = new System.Drawing.Point(6, 44);
            this.lbOrderNo.Name = "lbOrderNo";
            this.lbOrderNo.Size = new System.Drawing.Size(123, 20);
            this.lbOrderNo.TabIndex = 0;
            this.lbOrderNo.Text = "Sipariş Numarası:";
            // 
            // panPanel
            // 
            this.panPanel.BackColor = System.Drawing.Color.Tomato;
            this.panPanel.Location = new System.Drawing.Point(671, 351);
            this.panPanel.Name = "panPanel";
            this.panPanel.Size = new System.Drawing.Size(249, 12);
            this.panPanel.TabIndex = 2;
            // 
            // picBack
            // 
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(12, -2);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(33, 37);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 6;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 602);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.panPanel);
            this.Controls.Add(this.grpbxOrder_update);
            this.Controls.Add(this.grpbxNew_order);
            this.Controls.Add(this.dtgrdOrders);
            this.Name = "frmOrder";
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdOrders)).EndInit();
            this.grpbxNew_order.ResumeLayout(false);
            this.grpbxNew_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            this.grpbxOrder_update.ResumeLayout(false);
            this.grpbxOrder_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdOrders;
        private System.Windows.Forms.GroupBox grpbxNew_order;
        private System.Windows.Forms.GroupBox grpbxOrder_update;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lbCostumer_name;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label lbOrderNo;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Panel panPanel;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Button btnAdd_order;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnUpdate;
    }
}