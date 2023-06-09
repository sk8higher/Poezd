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
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            radioButton2 = new RadioButton();
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
            radioButton1.Padding = new Padding(5, 0, 0, 0);
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
            // label14
            // 
            label14.BackColor = SystemColors.InactiveCaption;
            label14.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(392, 328);
            label14.Name = "label14";
            label14.Size = new Size(80, 23);
            label14.TabIndex = 25;
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.InactiveCaption;
            label15.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(304, 328);
            label15.Name = "label15";
            label15.Size = new Size(72, 23);
            label15.TabIndex = 24;
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.InactiveCaption;
            label16.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(224, 328);
            label16.Name = "label16";
            label16.Size = new Size(72, 23);
            label16.TabIndex = 23;
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.InactiveCaption;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(144, 328);
            label17.Name = "label17";
            label17.Size = new Size(64, 23);
            label17.TabIndex = 22;
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = SystemColors.InactiveCaption;
            label18.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(40, 328);
            label18.Name = "label18";
            label18.Size = new Size(80, 23);
            label18.TabIndex = 21;
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.InactiveCaption;
            label19.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(384, 296);
            label19.Name = "label19";
            label19.Size = new Size(96, 23);
            label19.TabIndex = 20;
            label19.Text = "Saint Denis";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BackColor = SystemColors.InactiveCaption;
            label20.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(304, 296);
            label20.Name = "label20";
            label20.Size = new Size(72, 23);
            label20.TabIndex = 19;
            label20.Text = "Emerald";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = SystemColors.InactiveCaption;
            label21.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(224, 296);
            label21.Name = "label21";
            label21.Size = new Size(72, 23);
            label21.TabIndex = 18;
            label21.Text = "Valentine";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.BackColor = SystemColors.InactiveCaption;
            label22.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(144, 296);
            label22.Name = "label22";
            label22.Size = new Size(72, 23);
            label22.TabIndex = 17;
            label22.Text = "Rhodes";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.BackColor = SystemColors.InactiveCaption;
            label23.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(32, 296);
            label23.Name = "label23";
            label23.Size = new Size(104, 23);
            label23.TabIndex = 16;
            label23.Text = "Saint Denis";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = SystemColors.InactiveCaption;
            radioButton2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Green;
            radioButton2.Location = new Point(32, 256);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(5, 0, 0, 0);
            radioButton2.Size = new Size(448, 32);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Saint Denis - Rhodes - Valentine - Emerald - Saint Denis";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 845);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(radioButton2);
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
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private RadioButton radioButton2;
    }
}