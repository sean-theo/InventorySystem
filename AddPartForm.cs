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
        // Radio button change events to update dynamic label
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

        // Cancel buton
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save button
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

            if (rbtnInHouse.Checked)
            {
                if (!int.TryParse(txtDynamic.Text, out int machineID))
                {
                    MessageBox.Show(this, "Machine ID must be a number.");
                    return;
                }

                InHouse newInHousePart = new InHouse()
                {
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };
                Inventory.AddPart(newInHousePart);
            }
            else
            {
                string companyName = txtDynamic.Text;

                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show(this, "Company Name cannot be empty.");
                    return;
                }

                if (int.TryParse(companyName, out _))
                {
                    MessageBox.Show(this, "Company Name cannot be a number.");
                    return;
                }

                Outsourced newOutSourcedPart = new Outsourced()
                {
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };
                Inventory.AddPart(newOutSourcedPart);
            }

            this.Close();
        }
    }
}