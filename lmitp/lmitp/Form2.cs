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
    public partial class Form2 : Form
    {
        public event EventHandler DataChanged;
        addForm addform = new addForm();
        public Form2()
        {
            InitializeComponent();

            LoadFormData();
            addform.DataSelected += Addform_DataSelected;


        }
        private void HandleDataChanged()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            HandleDataChanged();
            UpdateGlobalData();
        }
        private void LoadFormData()
        {
            List<string[]> formDataCopy = new List<string[]>(GlobalData.Form2Data);

            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            // Add data from the copy of Form2Data collection to the DataGridView
            foreach (string[] data in formDataCopy)
            {
                dataGridView1.Rows.Add(data);
            }
        }


        private void UpdateGlobalData()
        {
            // Clear existing data in GlobalData.Form2Data
            GlobalData.Form2Data.Clear();

            // Load data from DataGridView to GlobalData.Form2Data
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] rowData = new string[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = Convert.ToString(row.Cells[i].Value);
                    }
                    GlobalData.Form2Data.Add(rowData);
                }
            }
        }


        private void Addform_DataSelected(object sender, DataSelectedEventArgs e)
        {
            // Add the selected data to the DataGridView
            dataGridView1.Rows.Add(e.Data);
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            GlobalData.Form2Data.Clear(); // Clear the data when the form is closed
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] rowData = new string[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = Convert.ToString(row.Cells[i].Value);
                    }
                    GlobalData.Form2Data.Add(rowData);
                }
            } */
        }
        //--------------------------------ADD--------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            
            using (addForm addform = new addForm())
            {
                if (addform.ShowDialog() == DialogResult.OK)
                {
                    // Get the data from addForm
                    string[] data = addform.GetData();
                    GlobalData.Form2Data.Add(data);
                    // Add the data to the DataGridView
                    dataGridView1.Rows.Add(data);

                }
            }
        }
//----------------------------------------------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------SEARCH------------------------------------------
        private void UpdateDataGridView()
        {
            // Get the selected search category from the ComboBox
            string selectedCategory = comboSearch.SelectedItem?.ToString();

            // Get the search keyword from the TextBox
            string searchKeyword = textSearch.Text.Trim().ToLower(); // Convert to lowercase

            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip the new row if it's in edit mode
                if (!row.IsNewRow)
                {
                    // Get the cell value based on the selected category
                    string cellValue = null;
                    if (selectedCategory == "Product Type")
                        cellValue = Convert.ToString(row.Cells["Column1"].Value)?.ToLower(); // Convert to lowercase
                    else if (selectedCategory == "Brand Name")
                        cellValue = Convert.ToString(row.Cells["Column2"].Value)?.ToLower(); // Convert to lowercase

                    // If the cell value contains the search keyword or if no search keyword is provided, make the row visible
                    // Otherwise, hide the row
                    if (string.IsNullOrEmpty(searchKeyword))
                    {
                        // Show the row if searchKeyword is empty or null
                        row.Visible = true;
                    }
                    else
                    {
                        // Hide the row if the cellValue is null or does not contain the searchKeyword
                        row.Visible = cellValue != null && cellValue.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0;
                    }
                }
            }
        }

    
        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Column5"].Index)
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < GlobalData.Form2Data.Count)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    string productType = selectedRow.Cells["Column1"].Value.ToString();
                    string brandName = selectedRow.Cells["Column2"].Value.ToString();
                    string pricePerUnit = selectedRow.Cells["Column3"].Value.ToString();
                    string quantity = selectedRow.Cells["Column4"].Value.ToString();

                    EditForm editForm = new EditForm(productType, brandName, pricePerUnit, quantity);
                    editForm.ShowDialog();

                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        GlobalData.Form2Data[selectedIndex] = new string[]
                        {
                editForm.ProductType,
                editForm.BrandName,
                editForm.PricePerUnit,
                editForm.Quantity
                        };

                        selectedRow.Cells["Column1"].Value = editForm.ProductType;
                        selectedRow.Cells["Column2"].Value = editForm.BrandName;
                        selectedRow.Cells["Column3"].Value = editForm.PricePerUnit;
                        selectedRow.Cells["Column4"].Value = editForm.Quantity;

                        HandleDataChanged();
                    }
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Column6"].Index)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int selectedIndex = e.RowIndex;
                    if (selectedIndex < GlobalData.Form2Data.Count)
                    {
                        GlobalData.Form2Data.RemoveAt(selectedIndex);
                        dataGridView1.Rows.RemoveAt(selectedIndex);
                        HandleDataChanged();
                    }
                }
            }
            
        }
        //------------------------------------------------------------------------------------------------------
   
        //--------------------------EDIT------------------------------------------------------
        private void EditRow(DataGridViewRow row)
    {
        string productType = row.Cells["Column1"].Value.ToString();
        string brandName = row.Cells["Column2"].Value.ToString();
        string pricePerUnit = row.Cells["Column3"].Value.ToString();
        string quantity = row.Cells["Column4"].Value.ToString();

        EditForm editForm = new EditForm(productType, brandName, pricePerUnit, quantity);
        editForm.ShowDialog();

        if (editForm.DialogResult == DialogResult.OK)
        {
            row.Cells["Column1"].Value = editForm.ProductType;
            row.Cells["Column2"].Value = editForm.BrandName;
            row.Cells["Column3"].Value = editForm.PricePerUnit;
            row.Cells["Column4"].Value = editForm.Quantity;
        }
    }
       

    }

}

