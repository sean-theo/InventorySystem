using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class ModifyProductForm : Form
    {
        private Product selectedProduct;
    
        public ModifyProductForm(Product product)
        {
            InitializeComponent();

           selectedProduct = product;
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            txtID.Text = selectedProduct.ProductID.ToString();
            txtName.Text = selectedProduct.Name;
            txtInventory.Text = selectedProduct.InStock.ToString();
            txtPrice.Text = selectedProduct.Price.ToString();
            txtMin.Text = selectedProduct.Min.ToString();
            txtMax.Text = selectedProduct.Max.ToString();

            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = selectedProduct.AssociatedParts;

            dgvAllParts.ClearSelection();
            dgvAssociatedParts.ClearSelection();
        }

        private void btnAddCandiadatePart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null)
            {
                MessageBox.Show(this, "Please select a part to add.");
                return;
            }

            Part selectedPart = (Part)dgvAllParts.CurrentRow.DataBoundItem;

            selectedProduct.AssociatedParts.Add(selectedPart);
            dgvAssociatedParts.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(this, "Name cannot be empty.");
                return;
            }

            if (!int.TryParse(txtInventory.Text, out int inventory))
            {
                MessageBox.Show(this, "Inventory must be a whole number.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show(this, "Price must be a valid decimal number.");
                return;
            }

            if (!int.TryParse(txtMin.Text, out int min) ||
                !int.TryParse(txtMax.Text, out int max))
            {
                MessageBox.Show(this, "Min and Max must be whole numbers.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show(this, "Min cannot be greater than Max.");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show(this, "Inventory must be between Min and Max.");
                return;
            }

            selectedProduct.Name = name;
            selectedProduct.InStock = inventory;
            selectedProduct.Price = price;
            selectedProduct.Min = min;
            selectedProduct.Max = max;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtCandiadateSearch.Text.Trim().ToLower();

            if (txtCandiadateSearch.Text == "")
            {
                MessageBox.Show(this, "Please enter a search term.");
                return;
            }

            if (int.TryParse(searchTerm, out int partID))
            {
                foreach (var part in Inventory.AllParts)
                {
                    if (part.PartID == partID)
                    {
                        dgvAllParts.ClearSelection();
                        int rowIndex = Inventory.AllParts.IndexOf(part);
                        dgvAllParts.Rows[rowIndex].Selected = true;
                        return;
                    }

                }
                dgvAllParts.ClearSelection();
                MessageBox.Show(this, "Part not found.");

            }
            else
            {
                foreach (var part in Inventory.AllParts)
                {
                    if (part.Name.ToLower().Contains(searchTerm))
                    {
                        dgvAllParts.ClearSelection();
                        int rowIndex = Inventory.AllParts.IndexOf(part);
                        dgvAllParts.Rows[rowIndex].Selected = true;
                        return;
                    }
                }
                dgvAllParts.ClearSelection();
                MessageBox.Show(this, "Part not found.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show(this, "Please select a part to remove.");
                return;
            }

            Part partToRemove = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show("Are you sure you want to remove this part from the product?",
                                          "Confirm Remove",
                                          MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                selectedProduct.AssociatedParts.Remove(partToRemove);
                dgvAssociatedParts.Refresh();
                dgvAssociatedParts.ClearSelection();
            }
        }
    }
}

