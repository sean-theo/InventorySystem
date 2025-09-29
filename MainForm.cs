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

            Part screw = new InHouse()
            {
                PartID = 1,
                Name = "Screw",
                Price = 0.25m,
                InStock = 100,
                Min = 10,
                Max = 500,
                MachineID = 123,
            };

            Part nail = new InHouse()
            {
                PartID = 2,
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
                ProductID = 1,
                Name = "Toolbox",
                Price = 19.99m,
                InStock = 15,
                Min = 1,
                Max = 50,
            };

            Inventory.Products.Add(toolbox);
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
                var confirmResult = MessageBox.Show(this, "Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Inventory.DeletePart(partToDelete);
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show(this, "Please select a part to delete.");
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
                foreach(var part in Inventory.AllParts)
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
    }
}
