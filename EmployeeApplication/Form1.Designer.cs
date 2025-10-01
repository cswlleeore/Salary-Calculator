namespace EmployeeApplication
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(516, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(516, 155);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(191, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(516, 261);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(220, 27);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 43);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 43);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 132);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 132);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Job Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 238);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Rate Per Hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(516, 238);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 11;
            label6.Text = "Total Hours Worked";
            // 
            // button1
            // 
            button1.Location = new Point(384, 308);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 12;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 367);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 13;
            label7.Text = "First Name:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(160, 404);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 14;
            label8.Text = "Last Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(160, 439);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 15;
            label9.Text = "Basic Salary:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 486);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Employee Salary Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
