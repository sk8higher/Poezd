namespace Poezd
{
    public partial class Form1 : Form
    {
        private int hour, minute, second;
        private int r, v;

        private string b; // кол-во баллов
        private int m; // кол-во рейсов

        private string sent, ann, emm, valen, rou, sent_prib, sent_prib2, ann_prib;

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

                radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                b += 1;
                m += 1;

                label18.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                sent = label18.Text;
                label17.Text = $"{time.AddMinutes(5 + r).AddSeconds(-time.Second):T}";
                rou = label17.Text;
                label16.Text = $"{time.AddMinutes(10 + r).AddSeconds(-time.Second):T}";
                valen = label16.Text;
                label15.Text = $"{time.AddMinutes(14 + r).AddSeconds(-time.Second):T}";
                emm = label15.Text;
                label14.Text = $"{time.AddMinutes(18 + r).AddSeconds(-time.Second):T}";
                sent_prib2 = label14.Text;

                radioButton1.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton3.Checked)
            {
                b += 1.2;
                m += 1;

                label28.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                sent = label28.Text;
                label27.Text = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";
                emm = label27.Text;
                label26.Text = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";
                valen = label26.Text;
                label25.Text = $"{time.AddMinutes(16 + r).AddSeconds(-time.Second):T}";
                rou = label25.Text;
                label24.Text = $"{time.AddMinutes(19 + r).AddSeconds(-time.Second):T}";
                sent_prib = label24.Text;
                label34.Text = $"{time.AddMinutes(23 + r).AddSeconds(-time.Second):T}";
                ann = label34.Text;

                radioButton1.Enabled = radioButton2.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton4.Checked)
            {
                b += 1.35;
                m += 1;

                label42.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                ann = label42.Text;
                label41.Text = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";
                sent = label41.Text;
                label40.Text = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";
                emm = label40.Text;
                label39.Text = $"{time.AddMinutes(17 + r).AddSeconds(-time.Second):T}";
                valen = label39.Text;
                label38.Text = $"{time.AddMinutes(21 + r).AddSeconds(-time.Second):T}";
                rou = label38.Text;
                label36.Text = $"{time.AddMinutes(24 + r).AddSeconds(-time.Second):T}";
                sent_prib = label36.Text;
                label49.Text = $"{time.AddMinutes(28 + r).AddSeconds(-time.Second):T}";
                ann_prib = label49.Text;

                radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
        }
    }
}