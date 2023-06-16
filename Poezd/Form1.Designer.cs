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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            trackBar1 = new TrackBar();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // radioButton2
            // 
            radioButton2.BackColor = SystemColors.InactiveCaption;
            radioButton2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Green;
            radioButton2.Location = new Point(32, 192);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(5, 0, 0, 0);
            radioButton2.Size = new Size(448, 32);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Saint Denis - Rhodes - Valentine - Emerald - Saint Denis";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = SystemColors.InactiveCaption;
            radioButton3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.Green;
            radioButton3.Location = new Point(32, 240);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(5, 0, 0, 0);
            radioButton3.Size = new Size(544, 32);
            radioButton3.TabIndex = 26;
            radioButton3.TabStop = true;
            radioButton3.Text = "Saint Denis - Emerald - Valentine - Rhodes - Saint Denis - Annesburg";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = SystemColors.InactiveCaption;
            radioButton4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.Green;
            radioButton4.Location = new Point(32, 288);
            radioButton4.Name = "radioButton4";
            radioButton4.Padding = new Padding(5, 0, 0, 0);
            radioButton4.Size = new Size(504, 32);
            radioButton4.TabIndex = 39;
            radioButton4.TabStop = true;
            radioButton4.Text = "Annesburg - Saint Denis - Emerald - Valentine - Rhodes - Saint Denis - Annesburg";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.BackColor = SystemColors.InactiveCaption;
            radioButton5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton5.ForeColor = Color.Green;
            radioButton5.Location = new Point(32, 336);
            radioButton5.Name = "radioButton5";
            radioButton5.Padding = new Padding(5, 0, 0, 0);
            radioButton5.Size = new Size(504, 32);
            radioButton5.TabIndex = 54;
            radioButton5.TabStop = true;
            radioButton5.Text = "Annesburg - Saint Denis - Rhodes - Valentine - Emerald - Saint Denis - Annesburg";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.BackColor = SystemColors.InactiveCaption;
            radioButton6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton6.ForeColor = Color.Green;
            radioButton6.Location = new Point(32, 384);
            radioButton6.Name = "radioButton6";
            radioButton6.Padding = new Padding(5, 0, 0, 0);
            radioButton6.Size = new Size(472, 32);
            radioButton6.TabIndex = 69;
            radioButton6.TabStop = true;
            radioButton6.Text = "Annesburg - Saint Denis - Emerald - Valentine - Rhodes - Saint Denis";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(56, 496);
            button1.Name = "button1";
            button1.Size = new Size(120, 56);
            button1.TabIndex = 82;
            button1.Text = "Расписание";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(184, 496);
            button2.Name = "button2";
            button2.Size = new Size(120, 56);
            button2.TabIndex = 83;
            button2.Text = "Закончить маршрут";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(312, 496);
            button3.Name = "button3";
            button3.Size = new Size(120, 56);
            button3.TabIndex = 84;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(440, 496);
            button4.Name = "button4";
            button4.Size = new Size(120, 56);
            button4.TabIndex = 85;
            button4.Text = "Удалить запись из рейса";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.Location = new Point(152, 424);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(312, 32);
            trackBar1.TabIndex = 86;
            trackBar1.Value = 10;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(184, 464);
            label4.Name = "label4";
            label4.Size = new Size(248, 23);
            label4.TabIndex = 87;
            label4.Text = "Прозрачность второй формы";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(624, 566);
            Controls.Add(label4);
            Controls.Add(trackBar1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "RE";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TrackBar trackBar1;
        private Label label4;
    }
}