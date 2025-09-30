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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;

            Part screw = new InHouse()
            {
                Name = "Screw",
                Price = 0.25m,
                InStock = 100,
                Min = 10,
                Max = 500,
                MachineID = 123,
            };

            Part nail = new InHouse()
            {
                Name = "Nail",
                Price = 0.25m,
                InStock = 100,
                Min = 10,
                Max = 500,
                MachineID = 789,
            };

            Inventory.AllParts.Add(screw);
            Inventory.AllParts.Add(nail);

            Product toolbox = new Product()
            {
                Name = "Toolbox",
                Price = 19.99m,
                InStock = 15,
                Min = 1,
                Max = 50,
            };

            Product chair = new Product()
            {
                Name = "Chair",
                Price = 24.99m,
                InStock = 25,
                Min = 10,
                Max = 50,
            };

            Inventory.Products.Add(toolbox);
            Inventory.Products.Add(chair);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.DataBoundItem is Part partToModify)
            {
                ModifyPartForm modifyPartForm = new ModifyPartForm(partToModify);
                modifyPartForm.ShowDialog();
                dgvParts.Refresh();
            }

            else
            {
                MessageBox.Show(this, "Please select a part to modify.");
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.DataBoundItem is Part partToDelete)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this part?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    bool deleted = Inventory.DeletePart(partToDelete);

                    if (!deleted)
                    {
                        MessageBox.Show("Cannot delete this part because it is associated with a product.");
                        return;
                    }

                    dgvParts.Refresh();
                    dgvParts.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchParts.Text.Trim().ToLower();

            if (txtSearchParts.Text == "")
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
                        dgvParts.ClearSelection();
                        int rowIndex = Inventory.AllParts.IndexOf(part);
                        dgvParts.Rows[rowIndex].Selected = true;
                        return;
                    }

                }
                dgvParts.ClearSelection();
                MessageBox.Show(this, "Part not found.");

            }
            else
            {
                foreach (var part in Inventory.AllParts)
                {
                    if (part.Name.ToLower().Contains(searchTerm))
                    {
                        dgvParts.ClearSelection();
                        int rowIndex = Inventory.AllParts.IndexOf(part);
                        dgvParts.Rows[rowIndex].Selected = true;
                        return;
                    }
                }
                dgvParts.ClearSelection();
                MessageBox.Show(this, "Part not found.");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product productToModify)
            {
                ModifyProductForm modifyProductForm = new ModifyProductForm(productToModify);
                modifyProductForm.ShowDialog();
                dgvParts.Refresh();
            }

            else
            {
                MessageBox.Show(this, "Please select a part to modify.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product productToDelete)
            {
                if (productToDelete.AssociatedParts.Count > 0)
                {
                    MessageBox.Show(this, "Cannot delete a product that has associated parts. Please remove associated parts first.");
                    return;
                }
                var confirmResult = MessageBox.Show(this, "Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(productToDelete.ProductID);
                    dgvProducts.Refresh();
                    dgvProducts.ClearSelection();
                }   
                else
                {
                }
            }
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchProducts.Text.Trim().ToLower();

            if (txtSearchProducts.Text == "")
            {
                MessageBox.Show(this, "Please enter a search term.");
                return;
            }

            if (int.TryParse(searchTerm, out int productID))
            {
                foreach (var product in Inventory.Products)
                {
                    if (product.ProductID == productID)
                    {
                        dgvProducts.ClearSelection();
                        int rowIndex = Inventory.Products.IndexOf(product);
                        dgvProducts.Rows[rowIndex].Selected = true;
                        return;
                    }

                }
                dgvProducts.ClearSelection();
                MessageBox.Show(this, "Product not found.");

            }
            else
            {
                foreach (var product in Inventory.Products)
                {
                    if (product.Name.ToLower().Contains(searchTerm))
                    {
                        dgvProducts.ClearSelection();
                        int rowIndex = Inventory.Products.IndexOf(product);
                        dgvProducts.Rows[rowIndex].Selected = true;
                        return;
                    }
                }
                dgvProducts.ClearSelection();
                MessageBox.Show(this, "Product not found.");
            }
        }
    }
}
