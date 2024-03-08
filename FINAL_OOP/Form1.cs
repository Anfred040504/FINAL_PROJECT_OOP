using FINAL_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_OOP

{
    public partial class Form1 : Form
    {
        public string itemValue { get; set; }
        public string quantityValue { get; set; }
        public string totalPriceValue { get; set; }

        public DataTable table1 = new DataTable();
        public DataTable table2 = new DataTable();
        public DataTable table3 = new DataTable();
        public DataTable table4 = new DataTable();
        public DataTable table5 = new DataTable();

       
            
        

        public void textBoxValue()
        {
            itemValue = textBox1.Text;
            quantityValue = textBox2.Text;
            totalPriceValue = textBox3.Text;
        }
        public void ClearAllTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public void TABLE()
        {
            table1.Columns.Add("ITEM", typeof(object));
            table1.Columns.Add("QUANTITY", typeof(object));
            table1.Columns.Add("TOTAL_PRICE", typeof(object));

            table2.Columns.Add("ITEM", typeof(object));
            table2.Columns.Add("QUANTITY", typeof(object));
            table2.Columns.Add("TOTAL_PRICE", typeof(object));

            table3.Columns.Add("ITEM", typeof(object));
            table3.Columns.Add("QUANTITY", typeof(object));
            table3.Columns.Add("TOTAL_PRICE", typeof(object));

            table4.Columns.Add("ITEM", typeof(object));
            table4.Columns.Add("QUANTITY", typeof(object));
            table4.Columns.Add("TOTAL_PRICE", typeof(object));

            table5.Columns.Add("ITEM", typeof(object));
            table5.Columns.Add("QUANTITY", typeof(object));
            table5.Columns.Add("TOTAL_PRICE", typeof(object));


            dataGridView1.DataSource = table1;
            dataGridView2.DataSource = table2;
            dataGridView3.DataSource = table3;
            dataGridView4.DataSource = table4;
            dataGridView5.DataSource = table4;
        }
        public Form1()
        {
            InitializeComponent();
            label1.Text = "ITEM";
            label3.Text = " QUANTITY";
            label2.Text = "TOTAL_PRICE";
            button1.Text = "DOGFOOD_DRY";
            button2.Text = "DOGFOOD_WET";
            button3.Text = "CATFOOD_DRY";
            button4.Text = "CATFOOD_WET";
            button5.Text = "CLEAR";
            button6.Text = "DELETE";
            button7.Text = "UPDATE";
            button8.Text = "MEDSTAB";
            tabPage1.Text = "DOGFOOD_DRY";
            tabPage2.Text = "DOGFOOD_WET";
            tabPage3.Text = "CATFOOD_DRY";
            tabPage4.Text = "CATFOOD_WET";
            tabPage5.Text = "MEDSTAB";
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dataGridView4.ReadOnly = true;
            dataGridView5.ReadOnly = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TABLE();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            table1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = table1;
            ClearAllTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table2.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView2.DataSource = table2;
            ClearAllTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table3.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView3.DataSource = table3;
            ClearAllTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table4.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView4.DataSource = table4;
            ClearAllTextBox();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView4 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ITEM"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["QUANTITY"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["TOTAL_PRICE"].Value.ToString();
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
           

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }

                    ClearAllTextBox();
                }

            }
        
    
            else if (dataGridView2.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                    ClearAllTextBox();
                }
            }
            else if (dataGridView3.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                    {
                        dataGridView3.Rows.Remove(row);
                    }
                    ClearAllTextBox();
                }
            }
            else if (dataGridView4.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView4.SelectedRows)
                    {
                        dataGridView4.Rows.Remove(row);
                    }
                    ClearAllTextBox();
                }
            }
            else if (dataGridView5.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView5.SelectedRows)
                    {
                        dataGridView5.Rows.Remove(row);
                    }
                    ClearAllTextBox();
                }
            }
            else
            {
                MessageBox.Show("Please Select A Row To Delete ");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBoxValue();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow1 = dataGridView1.SelectedRows[0];

                selectedRow1.Cells["ITEM"].Value = textBox1.Text;
                selectedRow1.Cells["QUANTITY"].Value = textBox2.Text;
                selectedRow1.Cells["TOTAL_PRICE"].Value = textBox3.Text;

                ClearAllTextBox();
            }

            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow2 = dataGridView2.SelectedRows[0];

                selectedRow2.Cells["ITEM"].Value = itemValue;
                selectedRow2.Cells["QUANTITY"].Value = quantityValue;
                selectedRow2.Cells["TOTAL_PRICE"].Value = totalPriceValue;
            }
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow3 = dataGridView3.SelectedRows[0];

                selectedRow3.Cells["ITEM"].Value = itemValue;
                selectedRow3.Cells["QUANTITY"].Value = quantityValue;
                selectedRow3.Cells["TOTAL_PRICE"].Value = totalPriceValue;
            }
            if (dataGridView4.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow4 = dataGridView4.SelectedRows[0];

                selectedRow4.Cells["ITEM"].Value = itemValue;
                selectedRow4.Cells["QUANTITY"].Value = quantityValue;
                selectedRow4.Cells["TOTAL_PRICE"].Value = totalPriceValue;
            }
            if (dataGridView5.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow5 = dataGridView5.SelectedRows[0];

                selectedRow5.Cells["ITEM"].Value = itemValue;
                selectedRow5.Cells["QUANTITY"].Value = quantityValue;
                selectedRow5.Cells["TOTAL_PRICE"].Value = totalPriceValue;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            table5.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView5.DataSource = table5;
            ClearAllTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView1 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ITEM"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["QUANTITY"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["TOTAL_PRICE"].Value.ToString();
                }
            }
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView5 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView5.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ITEM"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["QUANTITY"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["TOTAL_PRICE"].Value.ToString();
                }
            }
            }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView3 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ITEM"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["QUANTITY"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["TOTAL_PRICE"].Value.ToString();
                }
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView2 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ITEM"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["QUANTITY"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["TOTAL_PRICE"].Value.ToString();
                }
            }
    }
}
    }


