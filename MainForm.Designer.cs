namespace InventorySystem
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(416, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(11, 128);
            this.lblParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(68, 29);
            this.lblParts.TabIndex = 1;
            this.lblParts.Text = "Parts";
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Location = new System.Drawing.Point(500, 129);
            this.txtSearchParts.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(343, 22);
            this.txtSearchParts.TabIndex = 2;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(362, 125);
            this.btnSearchParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(100, 28);
            this.btnSearchParts.TabIndex = 3;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(13, 161);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.Size = new System.Drawing.Size(839, 449);
            this.dgvParts.TabIndex = 4;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(488, 630);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(100, 28);
            this.btnAddPart.TabIndex = 5;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(752, 630);
            this.btnDeletePart.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(100, 28);
            this.btnDeletePart.TabIndex = 7;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(920, 121);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(108, 29);
            this.lblProducts.TabIndex = 8;
            this.lblProducts.Text = "Products";
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(1432, 121);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(343, 22);
            this.txtSearchProducts.TabIndex = 9;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Location = new System.Drawing.Point(1297, 118);
            this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(100, 28);
            this.btnSearchProducts.TabIndex = 10;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(913, 161);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(862, 449);
            this.dgvProducts.TabIndex = 11;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(1675, 630);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(618, 630);
            this.btnModifyPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(100, 28);
            this.btnModifyPart.TabIndex = 13;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(1544, 630);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(100, 28);
            this.btnModifyProduct.TabIndex = 14;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1407, 630);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1675, 712);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1825, 752);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnExit;
    }
}

