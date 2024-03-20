using lmitp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lmitp
{
    public partial class addForm : Form
    {
        public event EventHandler<DataSelectedEventArgs> DataSelected;
        public addForm()
        {
            InitializeComponent();
        }
        public string[] GetData()
        {
            string productType = ProductType.Text;
            string productName = ProductName.Text;
            string quantity = Quantity.Text + " " + Quantby.Text;
            string price = Prize.Text;

            return new string[] { productType, productName, quantity, price };
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                


                string[] data = GetData();
               
                
                
                // Raise the DataSelected event with the selected data
                DataSelected?.Invoke(this, new DataSelectedEventArgs(data));
                // Save the data and close the form
                this.DialogResult = DialogResult.OK;


                MessageBox.Show("Item Added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateData()
        {
            // You can implement your validation logic here
            // For example, check if all required fields are filled
            if (string.IsNullOrWhiteSpace(ProductType.Text) ||
                string.IsNullOrWhiteSpace(ProductName.Text) ||
                string.IsNullOrWhiteSpace(Quantity.Text) ||
                string.IsNullOrWhiteSpace(Prize.Text))
            {
                return false;
            }

            return true;
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }
    }
}
