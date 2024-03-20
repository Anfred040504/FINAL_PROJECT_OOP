﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        public class DataAddedEventArgs : EventArgs
        {
            public string[] Data { get; }

            public DataAddedEventArgs(string[] data)
            {
                Data = data;
            }
        }

        private void btndashbaord_Click(object sender, EventArgs e)
        {
            loadform(new Form2());
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            loadform(new Form3());
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            loadform(new reportsform());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
