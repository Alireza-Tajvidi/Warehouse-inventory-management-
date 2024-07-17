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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbNumber = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCostumer_name = new System.Windows.Forms.Label();
            this.grpbxOrder_update = new System.Windows.Forms.GroupBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbOrderNo = new System.Windows.Forms.Label();
            this.panPanel = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdOrders)).BeginInit();
            this.grpbxNew_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpbxOrder_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdOrders
            // 
            this.dtgrdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdOrders.Location = new System.Drawing.Point(12, 41);
            this.dtgrdOrders.Name = "dtgrdOrders";
            this.dtgrdOrders.Size = new System.Drawing.Size(653, 549);
            this.dtgrdOrders.TabIndex = 0;
            // 
            // grpbxNew_order
            // 
            this.grpbxNew_order.Controls.Add(this.numericUpDown1);
            this.grpbxNew_order.Controls.Add(this.lbNumber);
            this.grpbxNew_order.Controls.Add(this.cmbItem);
            this.grpbxNew_order.Controls.Add(this.lbItem);
            this.grpbxNew_order.Controls.Add(this.textBox1);
            this.grpbxNew_order.Controls.Add(this.lbCostumer_name);
            this.grpbxNew_order.Location = new System.Drawing.Point(671, 55);
            this.grpbxNew_order.Name = "grpbxNew_order";
            this.grpbxNew_order.Size = new System.Drawing.Size(249, 269);
            this.grpbxNew_order.TabIndex = 1;
            this.grpbxNew_order.TabStop = false;
            this.grpbxNew_order.Text = "Yeni sipariş";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(10, 213);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(233, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(6, 190);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(55, 20);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.Text = "Miktar:";
            // 
            // cmbItem
            // 
            this.cmbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(10, 124);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(233, 28);
            this.cmbItem.TabIndex = 2;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(6, 100);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(43, 20);
            this.lbItem.TabIndex = 0;
            this.lbItem.Text = "Ürün:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lbCostumer_name
            // 
            this.lbCostumer_name.AutoSize = true;
            this.lbCostumer_name.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostumer_name.Location = new System.Drawing.Point(6, 29);
            this.lbCostumer_name.Name = "lbCostumer_name";
            this.lbCostumer_name.Size = new System.Drawing.Size(86, 20);
            this.lbCostumer_name.TabIndex = 0;
            this.lbCostumer_name.Text = "Müşteri adı:";
            // 
            // grpbxOrder_update
            // 
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
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(10, 159);
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
            this.lbState.Location = new System.Drawing.Point(6, 136);
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
            this.lbOrderNo.Size = new System.Drawing.Size(86, 20);
            this.lbOrderNo.TabIndex = 0;
            this.lbOrderNo.Text = "Müşteri adı:";
            // 
            // panPanel
            // 
            this.panPanel.BackColor = System.Drawing.Color.Tomato;
            this.panPanel.Location = new System.Drawing.Point(671, 340);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpbxOrder_update.ResumeLayout(false);
            this.grpbxOrder_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdOrders;
        private System.Windows.Forms.GroupBox grpbxNew_order;
        private System.Windows.Forms.GroupBox grpbxOrder_update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCostumer_name;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label lbOrderNo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Panel panPanel;
        private System.Windows.Forms.PictureBox picBack;
    }
}