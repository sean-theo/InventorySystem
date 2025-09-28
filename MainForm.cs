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

            Inventory.AllParts.Add(screw);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblParts_Click(object sender, EventArgs e)
        {

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchParts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
