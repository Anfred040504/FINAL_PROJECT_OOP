using FINAL_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FINAL_OOP.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_OOP
{

   
    public partial class Form1 : Form
    {

        public class Parent
        {
            public void MyMethod()
            {

            }
        }
        class Child : Parent
        {
            public void MyMethod()
            {

            }
        }
        class Child1 : Parent
        {
            public void MyMethod()
            {

            }
        }
        private object ID { get; set; }
        private object FULLNAME { get; set; }
        private object YEARLEVEL { get; set; }


        string id;

     

        public DataTable table1 = new DataTable();
        public DataTable table2 = new DataTable();
        public DataTable table3 = new DataTable();
        public DataTable table4 = new DataTable();
        public DataTable table5 = new DataTable();
        public DataTable table6 = new DataTable();
        public DataTable table7 = new DataTable();
        public DataTable table8 = new DataTable();

       
         List<string> dataGridView1IDs = new List<string>();
         List<string> dataGridView2IDs = new List<string>();
         List<string> dataGridView3IDs = new List<string>();
         List<string> dataGridView4IDs = new List<string>();
         List<string> dataGridView5IDs = new List<string>();
         List<string> dataGridView6IDs = new List<string>();
         List<string> dataGridView7IDs = new List<string>();
         List<string> dataGridView8IDs = new List<string>();

        

        public void textBoxValue()
        {
           
            ID = textBox1.Text.ToString();
            FULLNAME = textBox2.Text.ToString();
            YEARLEVEL = textBox3.Text.ToString();
        }
        
       
        public void updateInfo()
        {

            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedRows.Count < 0)
            {
               
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id))
                    {
                        MessageBox.Show("Sorry ID already Exist in BSIT");
                    }
                    else if (dataGridView2IDs.Contains(id))
                    {
                        MessageBox.Show("Sorry ID already Exist in BSBA");
                    }
                    else if (dataGridView3IDs.Contains(id))
                    {
                        MessageBox.Show("Sorry ID already Exist in BSHM");
                    }
                    else if (dataGridView4IDs.Contains(id))
                    {
                        MessageBox.Show("Sorry ID already Exist in BEED");
                    }
                    else if (dataGridView5IDs.Contains(id))
                    {
                       
                    }
                    else if (dataGridView6IDs.Contains(id))
                    {
                        MessageBox.Show("Sorry ID already Exist in BSCRIM");
                    }
                    else if (dataGridView7IDs.Contains(id))
                    {
                    }
                    else if (dataGridView8IDs.Contains(id))
                    {
                        MessageBox.Show("Sorry ID already Exist in SENIOR HIGH");
                    }
                    else
                    {
                        DataGridViewRow selectedRow1 = dataGridView1.SelectedRows[0];

                        selectedRow1.Cells["ID"].Value = textBox1.Text;
                        selectedRow1.Cells["FULL NAME"].Value = textBox2.Text;
                        selectedRow1.Cells["YEAR LEVEL"].Value = textBox3.Text;
                        selectedRow1.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                        selectedRow1.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                        ClearAllTextBox();
                    }
                }
            }
            else if (dataGridView2.SelectedRows.Count > 0 || dataGridView2.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {

                    DataGridViewRow selectedRow2 = dataGridView2.SelectedRows[0];

                    selectedRow2.Cells["ID"].Value = ID;
                    selectedRow2.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow2.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow2.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow2.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }
            else if (dataGridView3.SelectedRows.Count > 0 || dataGridView3.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    DataGridViewRow selectedRow3 = dataGridView3.SelectedRows[0];

                    selectedRow3.Cells["ID"].Value = ID;
                    selectedRow3.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow3.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow3.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow3.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }
            else if (dataGridView4.SelectedRows.Count > 0 || dataGridView4.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    DataGridViewRow selectedRow4 = dataGridView4.SelectedRows[0];

                    selectedRow4.Cells["ID"].Value = ID;
                    selectedRow4.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow4.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow4.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow4.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }
            else if (dataGridView5.SelectedRows.Count > 0 || dataGridView5.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    DataGridViewRow selectedRow5 = dataGridView5.SelectedRows[0];

                    selectedRow5.Cells["ID"].Value = ID;
                    selectedRow5.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow5.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow5.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow5.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }
            else if (dataGridView6.SelectedRows.Count > 0 || dataGridView6.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    DataGridViewRow selectedRow6 = dataGridView6.SelectedRows[0];

                    selectedRow6.Cells["ID"].Value = ID;
                    selectedRow6.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow6.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow6.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow6.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }
            else if (dataGridView7.SelectedRows.Count > 0 || dataGridView7.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    DataGridViewRow selectedRow7 = dataGridView7.SelectedRows[0];

                    selectedRow7.Cells["ID"].Value = ID;
                    selectedRow7.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow7.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow7.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow7.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }
            else if (dataGridView8.SelectedRows.Count > 0 || dataGridView8.SelectedRows.Count < 0)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("What you want to update?");
                }
                else
                {
                    DataGridViewRow selectedRow7 = dataGridView8.SelectedRows[0];

                    selectedRow7.Cells["ID"].Value = ID;
                    selectedRow7.Cells["FULL NAME"].Value = FULLNAME;
                    selectedRow7.Cells["YEAR LEVEL"].Value = YEARLEVEL;
                    selectedRow7.Cells["TIME"].Value = DateTime.Now.ToShortTimeString();
                    selectedRow7.Cells["DATE"].Value = DateTime.Now.ToShortDateString();

                    ClearAllTextBox();
                }
            }

            else
            {
                MessageBox.Show("Please select a row to Update");
            }
        }
        public void ClearAllTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public void TABLE()
        {
            table1.Columns.Add("ID", typeof(object));
            table1.Columns.Add("FULL NAME", typeof(object));
            table1.Columns.Add("YEAR LEVEL", typeof(object));
            table1.Columns.Add("TIME", typeof(object));
            table1.Columns.Add("DATE", typeof(object));

            table2.Columns.Add("ID", typeof(object));
            table2.Columns.Add("FULL NAME", typeof(object));
            table2.Columns.Add("YEAR LEVEL", typeof(object));
            table2.Columns.Add("TIME", typeof(object));
            table2.Columns.Add("DATE", typeof(object));

            table3.Columns.Add("ID", typeof(object));
            table3.Columns.Add("FULL NAME", typeof(object));
            table3.Columns.Add("YEAR LEVEL", typeof(object));
            table3.Columns.Add("TIME", typeof(object));
            table3.Columns.Add("DATE", typeof(object));

            table4.Columns.Add("ID", typeof(object));
            table4.Columns.Add("FULL NAME", typeof(object));
            table4.Columns.Add("YEAR LEVEL", typeof(object));
            table4.Columns.Add("TIME", typeof(object));
            table4.Columns.Add("DATE", typeof(object));

            table5.Columns.Add("ID", typeof(object));
            table5.Columns.Add("FULL NAME", typeof(object));
            table5.Columns.Add("YEAR LEVEL", typeof(object));
            table5.Columns.Add("TIME", typeof(object));
            table5.Columns.Add("DATE", typeof(object));

            table6.Columns.Add("ID", typeof(object));
            table6.Columns.Add("FULL NAME", typeof(object));
            table6.Columns.Add("YEAR LEVEL", typeof(object));
            table6.Columns.Add("TIME", typeof(object));
            table6.Columns.Add("DATE", typeof(object));

            table7.Columns.Add("ID", typeof(object));
            table7.Columns.Add("FULL NAME", typeof(object));
            table7.Columns.Add("YEAR LEVEL", typeof(object));
            table7.Columns.Add("TIME", typeof(object));
            table7.Columns.Add("DATE", typeof(object));

            table8.Columns.Add("ID", typeof(object));
            table8.Columns.Add("FULL NAME", typeof(object));
            table8.Columns.Add("YEAR LEVEL", typeof(object));
            table8.Columns.Add("TIME", typeof(object));
            table8.Columns.Add("DATE", typeof(object));

            dataGridView1.DataSource = table1;
            dataGridView2.DataSource = table2;
            dataGridView3.DataSource = table3;
            dataGridView4.DataSource = table4;
            dataGridView5.DataSource = table5;
            dataGridView6.DataSource = table6;
            dataGridView7.DataSource = table7;
            dataGridView8.DataSource = table8;
        }
        public void BUTTONS()
        {
            button1.Text = "BSIT";
            button2.Text = "BEED";
            button3.Text = "BSHM";
            button4.Text = "BSSC";
            button5.Text = "CLEAR";
            button6.Text = "DELETE";
            button7.Text = "UPDATE";
            button8.Text = "BSCRIM";
            button9.Text = "BSBA";
            button10.Text = "BSED";
            button11.Text = "SENIOR HIGH";

        }
        public void TABPAGE()
        {
            tabPage1.Text = "BSIT";
            tabPage2.Text = "BSBA";
            tabPage3.Text = "BSHM";
            tabPage4.Text = "BEED";
            tabPage5.Text = "BSED";
            tabPage6.Text = "BSCRIM";
            tabPage7.Text = "BSSC";
            tabPage8.Text = "SENIOR HIGH";
        }
        public void LABEL()
        {
            label1.Text = "ID";
            label2.Text = "YEAR LEVEL";
            label3.Text = "FULL NAME";
            label4.Text = "Charting Your Commitment, One Attendance Mark at a Time";
            comboBox1.Text = "SELECT";
        }

        public Form1()
        {
            InitializeComponent();

            LABEL();
            TABPAGE();
            BUTTONS();

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dataGridView4.ReadOnly = true;
            dataGridView5.ReadOnly = true;
            dataGridView6.ReadOnly = true;
            dataGridView7.ReadOnly = true;
            dataGridView8.ReadOnly = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            TABLE();
        }

        public void Check()
        {
            if (dataGridView1IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BSIT!");
                return;
            }
            else if (dataGridView2IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BSBA!");
                return;
            }
            else if (dataGridView3IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BSHM!");
                return;
            }
            else if (dataGridView4IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BEED!");
                return;
            }
            else if (dataGridView5IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BSED!");
                return;
            }
            else if (dataGridView6IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BSCRIM!");
                return;
            }
            else if (dataGridView7IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in BSSC!");
                return;
            }
            else if (dataGridView8IDs.Contains(id))
            {
                MessageBox.Show("ID already Exist in SENIOR HIGH!");
                return;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

           id = textBox1.Text.Trim();
           string value = textBox3.Text.Trim();

        if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
        {
            MessageBox.Show("Please fill up the blank!");
        }
        else
        {

            // Check if the value is 11 or 12
            if (value == "11" || value == "12")
            {
                MessageBox.Show("Please fill up Year Level correctly!");
            }
            else
            {
                    if (dataGridView1IDs.Contains(id)|| dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                        dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id) )
                    {
                       
                        Check();
                    }
                    else
                    {
                        table1.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView1.DataSource = table1;
                        dataGridView1IDs.Add(id);
                        ClearAllTextBox();
                    }
            }
        }

            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {




                // Check if the value is 11 or 12
                if (value == "11" || value == "12")
                {
                    MessageBox.Show("Please fill up Year Level correclty!");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                        dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table4.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView4.DataSource = table4;
                        dataGridView4IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {


                // Check if the value is 11 or 12
                if (value == "11" || value == "12")
                {
                    MessageBox.Show("Please fill up Year Level correclty!");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                        dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table3.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView3.DataSource = table3;
                        dataGridView3IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {

            // Check if the value is 11 or 12
            if (value == "11" || value == "12")
            {
                MessageBox.Show("Please fill up Year Level correclty!");
            }
            else
            {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                        dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table7.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView7.DataSource = table7;
                        dataGridView7IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ClearAllTextBox();
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
                        dataGridView1IDs.Remove(id);
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
                        dataGridView2IDs.Remove(id);
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
                        dataGridView3IDs.Remove(id);
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
                        dataGridView4IDs.Remove(id);
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
                        dataGridView5IDs.Remove(id);
                    }
                    ClearAllTextBox();
                }
            }
            else if (dataGridView6.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView6.SelectedRows)
                    {
                        dataGridView6.Rows.Remove(row);
                        dataGridView6IDs.Remove(id);
                    }
                    ClearAllTextBox();
                }
            }

            else if (dataGridView7.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView7.SelectedRows)
                    {
                        dataGridView7.Rows.Remove(row);
                        dataGridView7IDs.Remove(id);
                    }
                    ClearAllTextBox();
                }
            }
            else if (dataGridView8.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Do you want delete this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView8.SelectedRows)
                    {
                        dataGridView8.Rows.Remove(row);
                        dataGridView8IDs.Remove(id);
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

            id = textBox1.Text.Trim();

            updateInfo();
            
        }
        private void button9_Click(object sender, EventArgs e)
        {

            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {
                // Check if the value is 11 or 12
                if (value == "11" || value == "12")
                {
                    MessageBox.Show("Please fill up Year Level correctly!");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                      dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table2.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView2.DataSource = table2;
                        dataGridView2IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {

              

                // Check if the value is 11 or 12
                if (value == "11" || value == "12")
                {
                    MessageBox.Show("Please fill up Year Level correclty!!");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                        dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table5.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView5.DataSource = table5;
                        dataGridView5IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {

           

                // Check if the value is 11 or 12
                if (value == "11" || value == "12")
                {
                    MessageBox.Show("Please fill up Year Level correclty!");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                       dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table6.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView6.DataSource = table6;
                        dataGridView6IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }
        }

      
      

        private void button11_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            string value = textBox3.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill up the blank!");
            }
            else
            {
                // Check if the value is 11 or 12
                if (value == "1" || value == "2" || value == "3" || value == "4")
                {
                    MessageBox.Show("Please fill up Year Level correclty!");
                }
                else
                {
                    if (dataGridView1IDs.Contains(id) || dataGridView2IDs.Contains(id) || dataGridView3IDs.Contains(id) || dataGridView4IDs.Contains(id) || dataGridView5IDs.Contains(id) || dataGridView6IDs.Contains(id) ||
                        dataGridView7IDs.Contains(id) || dataGridView8IDs.Contains(id))
                    {

                        Check();
                    }
                    else
                    {
                        table8.Rows.Add(id, textBox2.Text, value, DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                        dataGridView8.DataSource = table8;
                        dataGridView8IDs.Add(id);
                        ClearAllTextBox();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = new string(text.Where(char.IsDigit).ToArray());

            if (text.Length > 10)
            {
                text = text.Substring(0, 10);
                System.Media.SystemSounds.Beep.Play();
            }

            textBox1.Text = text;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            string text = textBox3.Text;

            // Filter out non-numeric characters
            text = new string(text.Where(char.IsDigit).ToArray());

            // If the text is empty after filtering, leave the textbox empty and exit
            if (string.IsNullOrEmpty(text))
            {
                textBox3.Clear();
                return;
            }

            // Parse the text to an integer
            if (int.TryParse(text, out int number))
            {
                // Check if the number is within the specified ranges
                if (!((number >= 1 && number <= 4) || (number >= 11 && number <= 12)))
                {
                    // If not, set textbox to empty
                    textBox3.Clear();
                    return;
                }
            }
            else
            {
                // If parsing fails, set textbox to empty
                textBox3.Clear();
                return;
            }

            textBox3.Text = text;
            textBox3.SelectionStart = textBox3.Text.Length;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView1 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
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
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
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
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView4 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
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
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
                }
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView6 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView6.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
                }
            }
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView7 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView7.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
                }
            }
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sender == dataGridView8 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView8.Rows[e.RowIndex];
                    textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["FULL NAME"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["YEAR LEVEL"].Value.ToString();
                }
            }
        }

 
    }
}
   

    


