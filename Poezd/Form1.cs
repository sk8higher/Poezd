﻿namespace Poezd
{
    public partial class Form1 : Form
    {
        private int hour, minute, second;
        private int r, v;

        private string b; // кол-во баллов
        private int m; // кол-во рейсов

        private string sent, emm, valen, rou, sent_prib;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            label2.Text = $"Время {time:T}";

            hour = time.Hour;
            minute = time.Minute;
            second = 0;

            v = Int32.Parse(comboBox1.SelectedItem.ToString());

            if (v == 2)
                r = 0;
            else if (v == 5)
                r = 3;
            else if (v == 10)
                r = 8;

            if (radioButton1.Checked)
            {
                b += 1;
                m += 1;

                // добавляем минуты ко времени и обнуляем секунды
                label9.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                sent = label9.Text;
                label10.Text = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";
                emm = label10.Text;
                label11.Text = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";
                valen = label11.Text;
                label12.Text = $"{time.AddMinutes(16 + r).AddSeconds(-time.Second):T}";
                rou = label12.Text;
                label13.Text = $"{time.AddMinutes(18 + r).AddSeconds(-time.Second):T}";
                sent_prib = label13.Text;
            }
        }
    }
}