namespace lmitp
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button02 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.Prize1 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.Quantby1 = new System.Windows.Forms.ComboBox();
            this.Quantity1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel01 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductType1 = new System.Windows.Forms.ComboBox();
            this.button01 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductName1 = new System.Windows.Forms.TextBox();
            this.panel01.SuspendLayout();
            this.SuspendLayout();
            // 
            // button02
            // 
            this.button02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.button02.Location = new System.Drawing.Point(255, 171);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(65, 33);
            this.button02.TabIndex = 25;
            this.button02.Text = "Cancel";
            this.button02.UseVisualStyleBackColor = false;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(14, 168);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(70, 13);
            this.label51.TabIndex = 24;
            this.label51.Text = "Prize per Unit";
            // 
            // Prize1
            // 
            this.Prize1.Location = new System.Drawing.Point(17, 184);
            this.Prize1.Name = "Prize1";
            this.Prize1.Size = new System.Drawing.Size(126, 20);
            this.Prize1.TabIndex = 23;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(88, 111);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(19, 13);
            this.label41.TabIndex = 22;
            this.label41.Text = "By";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(14, 112);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 13);
            this.label31.TabIndex = 21;
            this.label31.Text = "Quantity";
            // 
            // Quantby1
            // 
            this.Quantby1.FormattingEnabled = true;
            this.Quantby1.Items.AddRange(new object[] {
            "kg",
            "pcs",
            "grams",
            "m"});
            this.Quantby1.Location = new System.Drawing.Point(92, 127);
            this.Quantby1.Name = "Quantby1";
            this.Quantby1.Size = new System.Drawing.Size(52, 21);
            this.Quantby1.TabIndex = 20;
            // 
            // Quantity1
            // 
            this.Quantity1.Location = new System.Drawing.Point(17, 128);
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Size = new System.Drawing.Size(68, 20);
            this.Quantity1.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(171, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Product Name";
            // 
            // panel01
            // 
            this.panel01.BackColor = System.Drawing.Color.Gray;
            this.panel01.Controls.Add(this.label1);
            this.panel01.Location = new System.Drawing.Point(0, 0);
            this.panel01.Name = "panel01";
            this.panel01.Size = new System.Drawing.Size(330, 29);
            this.panel01.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Form";
            // 
            // ProductType1
            // 
            this.ProductType1.FormattingEnabled = true;
            this.ProductType1.Items.AddRange(new object[] {
            "Dogfood Dry",
            "Dogfood Wet",
            "Dog Accessory",
            "Catfood Dry",
            "Catfood Wet",
            "Cat Accessory"});
            this.ProductType1.Location = new System.Drawing.Point(17, 69);
            this.ProductType1.Name = "ProductType1";
            this.ProductType1.Size = new System.Drawing.Size(121, 21);
            this.ProductType1.TabIndex = 16;
            // 
            // button01
            // 
            this.button01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(122)))), ((int)(((byte)(223)))));
            this.button01.Location = new System.Drawing.Point(174, 171);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(65, 33);
            this.button01.TabIndex = 15;
            this.button01.Text = "Save";
            this.button01.UseVisualStyleBackColor = false;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Product Type";
            // 
            // ProductName1
            // 
            this.ProductName1.Location = new System.Drawing.Point(174, 70);
            this.ProductName1.Name = "ProductName1";
            this.ProductName1.Size = new System.Drawing.Size(146, 20);
            this.ProductName1.TabIndex = 13;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 231);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.Prize1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.Quantby1);
            this.Controls.Add(this.Quantity1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel01);
            this.Controls.Add(this.ProductType1);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProductName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.panel01.ResumeLayout(false);
            this.panel01.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox Prize1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox Quantby1;
        private System.Windows.Forms.TextBox Quantity1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel01;
        private System.Windows.Forms.ComboBox ProductType1;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ProductName1;
        private System.Windows.Forms.Label label1;
    }
}