using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmitp
{
    public partial class EditForm : Form
    {
        public string ProductType { get; set; }
        public string BrandName { get; set; }
        public string PricePerUnit { get; set; }
        public string Quantity { get; set; }
        public EditForm(string productType, string brandName, string pricePerUnit, string quantity)
        {
            InitializeComponent();

            // Initialize controls with existing data
            ProductType1.Text = productType;
            ProductName1.Text = brandName;
            string[] priceAndUnit = pricePerUnit.Split(' ');
            Prize1.Text = priceAndUnit[0];
            Quantby1.SelectedItem = priceAndUnit[1];
            Quantity1.Text = quantity;

            // Set form title
            Text = "Edit Item";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void button01_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                // Update properties with edited data
                ProductType = ProductType1.Text;
                BrandName = ProductName1.Text;
                PricePerUnit = Prize1.Text + " " + Quantby1.SelectedItem.ToString(); // Updated to Quantby1
                Quantity = Quantity1.Text;

                // Set dialog result to OK and close the form
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            // Check if all required fields are filled
            return !string.IsNullOrWhiteSpace(ProductType1.Text) &&
                   !string.IsNullOrWhiteSpace(ProductName1.Text) &&
                   !string.IsNullOrWhiteSpace(Prize1.Text) &&
                   Quantby1.SelectedItem != null && // Check if an item is selected in Quantby1
                   !string.IsNullOrWhiteSpace(Quantity1.Text);
        
    }

        private void button02_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
