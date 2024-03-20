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

namespace lmitp
{
    public partial class Form3 : Form
    {
        addForm addform = new addForm();
        Form2 form2 = new Form2();

        public Form3()
        {
            InitializeComponent();
            // LoadFormData();
            // addform.DataSelected += Addform_DataSelected;
            form2.DataChanged += Form2_DataChanged;
        }
        private void Form2_DataChanged(object sender, EventArgs e)
        {
            // Update salesDataGrid when data in Form2 changes
            LoadFormData();
        }
        private void LoadFormData()
        {
            salesDataGrid.Rows.Clear();

            foreach (string[] data in GlobalData.Form2Data)
            {
                salesDataGrid.Rows.Add(data);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadFormData();
         //   foreach (string[] data in GlobalData.Form2Data)
          //  {
           //     salesDataGrid.Rows.Add(data);
          //  }
        }
        private void Addform_DataSelected(object sender, DataSelectedEventArgs e)
        {
            // Add the selected data to the DataGridView
        //    salesDataGrid.Rows.Add(e.Data);
        }

        private void salesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0 && e.ColumnIndex == salesDataGrid.Columns["Column4"].Index)
                {
                    DataGridViewRow selectedRow = salesDataGrid.Rows[e.RowIndex];

                    listBox1.Items.Clear(); // Clear existing items in the ListBox

                    // Assuming Column5 is the correct column index
                    string cellValue5 = selectedRow.Cells["Column3"].Value.ToString();
                    string cellValue2 = selectedRow.Cells["Column2"].Value.ToString();
                    string cellValue3 = selectedRow.Cells["Column5"].Value.ToString();


                    string add = cellValue5 + " " + cellValue2 + " = " + cellValue3;
                    listBox1.Items.Add(add);


                }


            
        }
        
        
        

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

      
    }
}
