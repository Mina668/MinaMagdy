﻿namespace Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            txtJob = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSalary = new TextBox();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            button5 = new Button();
            txtid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 326);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(127, 113);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(207, 27);
            txtJob.TabIndex = 2;
            txtJob.TextChanged += txtJob_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Job";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(25, 144);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Salary";
            label4.Click += label4_Click;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(127, 144);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(207, 27);
            txtSalary.TabIndex = 6;
            txtSalary.TextChanged += textBox2_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 7;
            txtName.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(749, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(127, 326);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(240, 326);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(465, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 233);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 249);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 13;
            label5.Text = "Name:";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(574, 262);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = ".....";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 303);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Search";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(374, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(294, 27);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(680, 326);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 18;
            button5.Text = "Show";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(127, 23);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(70, 27);
            txtid.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(txtid);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(txtSalary);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtJob);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtJob;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSalary;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Button button4;
        private Label label6;
        private TextBox textBox5;
        private Button button5;
        private TextBox txtid;
    }
}
