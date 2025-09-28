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
    public partial class ModifyPartForm : Form
    {
        private Part selectedPart;
        public ModifyPartForm(Part part)
        {
            InitializeComponent();
            selectedPart = part;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            selectedPart.Name = txtName.Text;
            selectedPart.InStock = Convert.ToInt32(txtInventory.Text);
            selectedPart.Price = Convert.ToDecimal(txtPrice.Text);
            selectedPart.Min = Convert.ToInt32(txtMin.Text);
            selectedPart.Max = Convert.ToInt32(txtMax.Text);

            if (rbtnInHouse.Checked && selectedPart is InHouse inHousePart)
            {
                inHousePart.MachineID = Convert.ToInt32(txtDynamic.Text);
            }
            else if (rbtnOutsourced.Checked && selectedPart is Outsourced outsourcedPart)
            {
                outsourcedPart.CompanyName = txtDynamic.Text;
            }
            this.Close();
        }
        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            txtID.Text = selectedPart.PartID.ToString();
            txtName.Text = selectedPart.Name;
            txtInventory.Text = selectedPart.InStock.ToString();
            txtPrice.Text = selectedPart.Price.ToString();
            txtMin.Text = selectedPart.Min.ToString();
            txtMax.Text = selectedPart.Max.ToString();

            if (selectedPart is InHouse inHousePart)
            {
                rbtnInHouse.Checked = true;
                lblDynamic.Text = "Machine ID";
                txtDynamic.Text = inHousePart.MachineID.ToString();
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                rbtnOutsourced.Checked = true;
                lblDynamic.Text = "Company Name";
                txtDynamic.Text = outsourcedPart.CompanyName;
            }
        }
    }
}
