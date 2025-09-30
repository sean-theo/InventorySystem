using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AddProductForm : Form
    {
        private Product newProduct = new Product();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            dgvAllParts.DataSource = Inventory.AllParts;
            txtID.Text = newProduct.ProductID.ToString();

            dgvAssociatedParts.DataSource = newProduct.AssociatedParts;
        }

        private void btnAddCandiadatePart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null)
            {
                MessageBox.Show(this, "Please select a part to add.");
                return;
            }

            Part selectedPart = (Part)dgvAllParts.CurrentRow.DataBoundItem;
            newProduct.AssociatedParts.Add(selectedPart);
            dgvAssociatedParts.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show(this, "Please select a part to remove.");
                return;
            }
            var dialogueResult = MessageBox.Show("Are you sure you want to delete this part?","Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogueResult == DialogResult.Yes)
            {
                Part selectedPart = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;
                newProduct.AssociatedParts.Remove(selectedPart);
                dgvAssociatedParts.Refresh();
            }
            else             
            {
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int inventory = Convert.ToInt32(txtInventory.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int min = Convert.ToInt32(txtMin.Text); 
            int max = Convert.ToInt32(txtMax.Text);

            if (name == "")
            {
                MessageBox.Show(this, "Name field cannot be empty.");
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

            newProduct.Name = name;
            newProduct.InStock = inventory;
            newProduct.Price = price;
            newProduct.Min = min;
            newProduct.Max = max;

            Inventory.Products.Add(newProduct);
            this.Close();
        }
    }
}
