namespace InventorySystem
{
    partial class AddProductForm
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
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblCandidateParts = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCanddidateSearcj = new System.Windows.Forms.TextBox();
            this.btnAddCandiadatePart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAssociatedParts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(25, 30);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(170, 32);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Add Product";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(34, 306);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 361);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(12, 422);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(67, 18);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(34, 482);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(28, 540);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(32, 18);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(232, 539);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(36, 18);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max";
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.AllowUserToAddRows = false;
            this.dgvAllParts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(555, 168);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.RowHeadersWidth = 51;
            this.dgvAllParts.RowTemplate.Height = 24;
            this.dgvAllParts.Size = new System.Drawing.Size(807, 285);
            this.dgvAllParts.TabIndex = 7;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AllowUserToAddRows = false;
            this.dgvAssociatedParts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(555, 539);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 51;
            this.dgvAssociatedParts.RowTemplate.Height = 24;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(807, 286);
            this.dgvAssociatedParts.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 302);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(145, 22);
            this.txtID.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 361);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(95, 421);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(145, 22);
            this.txtInventory.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(95, 479);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(95, 539);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(109, 22);
            this.txtMin.TabIndex = 13;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(308, 539);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(123, 22);
            this.txtMax.TabIndex = 14;
            // 
            // lblCandidateParts
            // 
            this.lblCandidateParts.AutoSize = true;
            this.lblCandidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateParts.Location = new System.Drawing.Point(551, 124);
            this.lblCandidateParts.Name = "lblCandidateParts";
            this.lblCandidateParts.Size = new System.Drawing.Size(174, 22);
            this.lblCandidateParts.TabIndex = 15;
            this.lblCandidateParts.Text = "All Candiadate Parts";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1030, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 38);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCanddidateSearcj
            // 
            this.txtCanddidateSearcj.Location = new System.Drawing.Point(1130, 124);
            this.txtCanddidateSearcj.Name = "txtCanddidateSearcj";
            this.txtCanddidateSearcj.Size = new System.Drawing.Size(232, 22);
            this.txtCanddidateSearcj.TabIndex = 17;
            // 
            // btnAddCandiadatePart
            // 
            this.btnAddCandiadatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCandiadatePart.Location = new System.Drawing.Point(1287, 475);
            this.btnAddCandiadatePart.Name = "btnAddCandiadatePart";
            this.btnAddCandiadatePart.Size = new System.Drawing.Size(75, 33);
            this.btnAddCandiadatePart.TabIndex = 18;
            this.btnAddCandiadatePart.Text = "Add";
            this.btnAddCandiadatePart.UseVisualStyleBackColor = true;
            this.btnAddCandiadatePart.Click += new System.EventHandler(this.btnAddCandiadatePart_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1282, 841);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1287, 896);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1191, 896);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAssociatedParts
            // 
            this.lblAssociatedParts.AutoSize = true;
            this.lblAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociatedParts.Location = new System.Drawing.Point(555, 492);
            this.lblAssociatedParts.Name = "lblAssociatedParts";
            this.lblAssociatedParts.Size = new System.Drawing.Size(282, 22);
            this.lblAssociatedParts.TabIndex = 22;
            this.lblAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1507, 971);
            this.Controls.Add(this.lblAssociatedParts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCandiadatePart);
            this.Controls.Add(this.txtCanddidateSearcj);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCandidateParts);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAddProduct);
            this.Name = "AddProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblCandidateParts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCanddidateSearcj;
        private System.Windows.Forms.Button btnAddCandiadatePart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAssociatedParts;
    }
}