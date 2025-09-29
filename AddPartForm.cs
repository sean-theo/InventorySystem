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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }
        private void rbtnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInHouse.Checked)
            {
                lblDynamic.Text = "Machine ID";
            }
        }
        private void rbtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOutsourced.Checked)
            {
                lblDynamic.Text = "Company Name";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int inventory = Convert.ToInt32(txtInventory.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int min = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);

            if (rbtnInHouse.Checked)
            {
                int machineID = Convert.ToInt32(txtDynamic.Text);
                InHouse newInHousePart = new InHouse()
                {
                    PartID = 2,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };
                Inventory.AllParts.Add(newInHousePart);
            }
            else
            {
                string companyName = txtDynamic.Text;
                Outsourced newOutSourcedPart = new Outsourced()
                {
                    PartID = 3,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };
                Inventory.AllParts.Add(newOutSourcedPart);
            }
            this.Close();
        }
    }
}