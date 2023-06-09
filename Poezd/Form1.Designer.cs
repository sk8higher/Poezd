namespace Poezd
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
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(136, 16);
            label1.Name = "label1";
            label1.Size = new Size(336, 80);
            label1.TabIndex = 0;
            label1.Text = "Расписание движения паравозов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(152, 104);
            label2.Name = "label2";
            label2.Size = new Size(288, 32);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(488, 72);
            label3.Name = "label3";
            label3.Size = new Size(104, 64);
            label3.TabIndex = 2;
            label3.Text = "Выберите время стоянки перед отправлением";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Red;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2", "5", "10" });
            comboBox1.Location = new Point(520, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(48, 24);
            comboBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = SystemColors.InactiveCaption;
            radioButton1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Green;
            radioButton1.Location = new Point(32, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(448, 32);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Saint Denis - Emerald - Valentine - Rhodes - Saint Denis";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(32, 184);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 5;
            label4.Text = "Saint Denis";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(144, 184);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 6;
            label5.Text = "Emerald";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(224, 184);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 7;
            label6.Text = "Valentine";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(304, 184);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 8;
            label7.Text = "Rhodes";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.InactiveCaption;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(384, 184);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 9;
            label8.Text = "Saint Denis";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.InactiveCaption;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(40, 216);
            label9.Name = "label9";
            label9.Size = new Size(80, 23);
            label9.TabIndex = 10;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.InactiveCaption;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(144, 216);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 11;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.InactiveCaption;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(224, 216);
            label11.Name = "label11";
            label11.Size = new Size(72, 23);
            label11.TabIndex = 12;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.InactiveCaption;
            label12.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(304, 216);
            label12.Name = "label12";
            label12.Size = new Size(72, 23);
            label12.TabIndex = 13;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.InactiveCaption;
            label13.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(392, 216);
            label13.Name = "label13";
            label13.Size = new Size(80, 23);
            label13.TabIndex = 14;
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 845);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RE";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}