namespace Poezd
{
    public partial class Form1 : Form
    {
        private int hour, minute, second;

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
        }
    }
}