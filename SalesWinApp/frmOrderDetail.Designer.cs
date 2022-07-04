namespace SalesWinApp
{
    partial class frmOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderDetail));
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            this.gbDetailInfo = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).BeginInit();
            this.gbDetailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(369, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(178, 38);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Order Detail";
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Controls.Add(this.dgvOrderDetailList);
            this.gbGeneralInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbGeneralInfo.Location = new System.Drawing.Point(12, 192);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(885, 205);
            this.gbGeneralInfo.TabIndex = 15;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "General Information";
            // 
            // dgvOrderDetailList
            // 
            this.dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailList.Location = new System.Drawing.Point(7, 26);
            this.dgvOrderDetailList.Name = "dgvOrderDetailList";
            this.dgvOrderDetailList.ReadOnly = true;
            this.dgvOrderDetailList.RowHeadersWidth = 51;
            this.dgvOrderDetailList.RowTemplate.Height = 29;
            this.dgvOrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailList.Size = new System.Drawing.Size(873, 184);
            this.dgvOrderDetailList.TabIndex = 0;
            // 
            // gbDetailInfo
            // 
            this.gbDetailInfo.Controls.Add(this.txtDiscount);
            this.gbDetailInfo.Controls.Add(this.btnDelete);
            this.gbDetailInfo.Controls.Add(this.btnUpdate);
            this.gbDetailInfo.Controls.Add(this.txtUnitPrice);
            this.gbDetailInfo.Controls.Add(this.btnAdd);
            this.gbDetailInfo.Controls.Add(this.txtQuantity);
            this.gbDetailInfo.Controls.Add(this.txtProductID);
            this.gbDetailInfo.Controls.Add(this.txtOrderID);
            this.gbDetailInfo.Controls.Add(this.lbDiscount);
            this.gbDetailInfo.Controls.Add(this.lbQuantity);
            this.gbDetailInfo.Controls.Add(this.lbUnitPrice);
            this.gbDetailInfo.Controls.Add(this.lbOrderID);
            this.gbDetailInfo.Controls.Add(this.lbProductID);
            this.gbDetailInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDetailInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbDetailInfo.Location = new System.Drawing.Point(18, 70);
            this.gbDetailInfo.Name = "gbDetailInfo";
            this.gbDetailInfo.Size = new System.Drawing.Size(813, 116);
            this.gbDetailInfo.TabIndex = 9;
            this.gbDetailInfo.TabStop = false;
            this.gbDetailInfo.Text = "Detail Information";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Image = global::SalesWinApp.Properties.Resources.orderDelete;
            this.btnDelete.Location = new System.Drawing.Point(754, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Image = global::SalesWinApp.Properties.Resources.allUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(754, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 41);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(548, 25);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(143, 27);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Image = global::SalesWinApp.Properties.Resources.orderAdd;
            this.btnAdd.Location = new System.Drawing.Point(697, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 41);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(313, 27);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 27);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(86, 74);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(150, 27);
            this.txtProductID.TabIndex = 7;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(86, 27);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(150, 27);
            this.txtOrderID.TabIndex = 6;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(242, 81);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(66, 20);
            this.lbDiscount.TabIndex = 5;
            this.lbDiscount.Text = "Discount";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(242, 34);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(470, 32);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 2;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(6, 34);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(64, 20);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(6, 81);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(78, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Image = global::SalesWinApp.Properties.Resources.backToHome;
            this.btnBack.Location = new System.Drawing.Point(837, 88);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 88);
            this.btnBack.TabIndex = 28;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(313, 74);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(150, 27);
            this.txtDiscount.TabIndex = 19;
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 409);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbDetailInfo);
            this.Controls.Add(this.gbGeneralInfo);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            this.gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).EndInit();
            this.gbDetailInfo.ResumeLayout(false);
            this.gbDetailInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private GroupBox gbGeneralInfo;
        private DataGridView dgvOrderDetailList;
        private GroupBox gbDetailInfo;
        private TextBox txtProductID;
        private TextBox txtOrderID;
        private Label lbDiscount;
        private Label lbQuantity;
        private Label lbUnitPrice;
        private Label lbOrderID;
        private Label lbProductID;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private TextBox txtDiscount;
    }
}