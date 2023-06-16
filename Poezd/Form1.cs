namespace Poezd
{
    public partial class Form1 : Form
    {
        private DateTime time;

        private Form2 secondForm;

        private int hour, minute, second;
        private int r, v;

        private double b; // кол-во баллов
        private int m; // кол-во рейсов

        private string sent, ann, emm, valen, rou, sent_prib, sent_prib2, sent_prib3, ann_prib, ann_prib2;

        private bool closeButtonClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            b = m = 0;
            button2.Enabled = button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secondForm = new();
            
            secondForm.Show();

            // Получаем ссылку на вторую форму
            //secondForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            time = DateTime.Now;
            label2.Text = $"Время {time:T}";

            hour = time.Hour;
            minute = time.Minute;
            second = 0;

            button2.Enabled = button4.Enabled = true;

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
                sent = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";

                secondForm.label1.Text = "Saint Denis";
                secondForm.label2.Text = sent;

                emm = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";

                secondForm.label4.Text = "Emerald";
                secondForm.label3.Text = emm;

                valen = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";

                secondForm.label6.Text = "Valentine";
                secondForm.label5.Text = valen;

                rou = $"{time.AddMinutes(16 + r).AddSeconds(-time.Second):T}";

                secondForm.label8.Text = "Rhodes";
                secondForm.label7.Text = rou;

                sent_prib = $"{time.AddMinutes(18 + r).AddSeconds(-time.Second):T}";

                secondForm.label10.Text = "Saint Denis";
                secondForm.label9.Text = sent_prib;

                radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                b += 1;
                m += 1;

                sent = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";

                secondForm.label1.Text = "Saint Denis";
                secondForm.label2.Text = sent;

                rou = $"{time.AddMinutes(5 + r).AddSeconds(-time.Second):T}";

                secondForm.label4.Text = "Rhodes";
                secondForm.label3.Text = rou;

                valen = $"{time.AddMinutes(10 + r).AddSeconds(-time.Second):T}";

                secondForm.label6.Text = "Valentine";
                secondForm.label5.Text = valen;

                emm = $"{time.AddMinutes(14 + r).AddSeconds(-time.Second):T}";

                secondForm.label8.Text = "Emerald";
                secondForm.label7.Text = emm;

                sent_prib2 = $"{time.AddMinutes(18 + r).AddSeconds(-time.Second):T}";

                secondForm.label10.Text = "Saint Denis";
                secondForm.label9.Text = sent_prib2;

                radioButton1.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton3.Checked)
            {
                b += 1.2;
                m += 1;

                sent = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";

                secondForm.label1.Text = "Saint Denis";
                secondForm.label2.Text = sent;

                emm = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";

                secondForm.label4.Text = "Emerald";
                secondForm.label3.Text = emm;

                valen = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";

                secondForm.label6.Text = "Valentine";
                secondForm.label5.Text = valen;

                rou = $"{time.AddMinutes(16 + r).AddSeconds(-time.Second):T}";

                secondForm.label8.Text = "Rhodes";
                secondForm.label7.Text = rou;

                sent_prib = $"{time.AddMinutes(19 + r).AddSeconds(-time.Second):T}";

                secondForm.label10.Text = "Saint Denis";
                secondForm.label9.Text = sent_prib;

                ann = $"{time.AddMinutes(23 + r).AddSeconds(-time.Second):T}";

                secondForm.Width += 96;

                secondForm.label12.Text = "Annesburg";
                secondForm.label11.Text = ann;

                radioButton1.Enabled = radioButton2.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton4.Checked)
            {
                b += 1.35;
                m += 1;

                ann = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";

                secondForm.label1.Text = "Annesburg";
                secondForm.label2.Text = ann;

                sent = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";

                secondForm.label4.Text = "Saint Denis";
                secondForm.label3.Text = sent;

                emm = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";

                secondForm.label6.Text = "Emerald";
                secondForm.label5.Text = emm;

                valen = $"{time.AddMinutes(17 + r).AddSeconds(-time.Second):T}";

                secondForm.label8.Text = "Valentine";
                secondForm.label7.Text = valen;

                rou = $"{time.AddMinutes(21 + r).AddSeconds(-time.Second):T}";

                secondForm.label10.Text = "Rhodes";
                secondForm.label9.Text = rou;

                sent_prib = $"{time.AddMinutes(24 + r).AddSeconds(-time.Second):T}";

                secondForm.Width += 96;
                secondForm.label12.Text = "Saint Dennis";
                secondForm.label11.Text = sent_prib;

                ann_prib = $"{time.AddMinutes(28 + r).AddSeconds(-time.Second):T}";

                secondForm.Width += 96;
                secondForm.label14.Text = "Annesburg";
                secondForm.label13.Text = ann_prib;

                radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton5.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton5.Checked)
            {
                b += 1.35;
                m += 1;

                ann = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";

                secondForm.label1.Text = "Annesburg";
                secondForm.label2.Text = ann;

                sent = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";

                secondForm.label4.Text = "Saint Denis";
                secondForm.label3.Text = sent;

                rou = $"{time.AddMinutes(10 + r).AddSeconds(-time.Second):T}";

                secondForm.label6.Text = "Rhodes";
                secondForm.label5.Text = rou;

                valen = $"{time.AddMinutes(15 + r).AddSeconds(-time.Second):T}";

                secondForm.label8.Text = "Valentine";
                secondForm.label7.Text = valen;


                emm = $"{time.AddMinutes(19 + r).AddSeconds(-time.Second):T}";

                secondForm.label10.Text = "Emerald";
                secondForm.label9.Text = emm;

                sent_prib = $"{time.AddMinutes(22 + r).AddSeconds(-time.Second):T}";

                secondForm.Width += 96;
                secondForm.label12.Text = "Saint Dennis";
                secondForm.label11.Text = sent_prib;

                ann_prib2 = $"{time.AddMinutes(26 + r).AddSeconds(-time.Second):T}";

                secondForm.Width += 96;
                secondForm.label14.Text = "Annesburg";
                secondForm.label13.Text = ann_prib2;

                radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton6.Checked)
            {
                b += 1.2;
                m += 1;

                ann = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";

                secondForm.label1.Text = "Annesburg";
                secondForm.label2.Text = ann;

                sent = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";

                secondForm.label4.Text = "Saint Denis";
                secondForm.label3.Text = sent;

                emm = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";

                secondForm.label6.Text = "Emerald";
                secondForm.label5.Text = emm;

                valen = $"{time.AddMinutes(17 + r).AddSeconds(-time.Second):T}";

                secondForm.label8.Text = "Valentine";
                secondForm.label7.Text = valen;

                rou = $"{time.AddMinutes(21 + r).AddSeconds(-time.Second):T}";

                secondForm.label10.Text = "Rhodes";
                secondForm.label9.Text = rou;

                sent_prib3 = $"{time.AddMinutes(24 + r).AddSeconds(-time.Second):T}";

                secondForm.Width += 96;
                secondForm.label12.Text = "Saint Dennis";
                secondForm.label11.Text = sent_prib3;

                radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }

            if (radioButton1.Checked)
            {
                Clipboard.SetText(
                    "```\n" +
                    "Маршрут: Saint Denis - Emerald - Valentine - Rhodes - Saint Denis\n" +
                    $"Отправление из Saint Denis - {sent}\n" +
                    $"Отправление из Emerald - {emm}\n" +
                    $"Отправление из Valentine - {valen}\n" +
                    $"Отправление из Rhodes - {rou}\n" +
                    $"Прибытие в Saint Denis - {sent_prib}\n" +
                    "```"
                );
            }
            else if (radioButton2.Checked)
            {
                Clipboard.SetText(
                    "```\n" +
                    "Маршрут: Saint Denis - Rhodes - Valentine - Emerald - Saint Denis\n" +
                    $"Отправление из Saint Denis - {sent}\n" +
                    $"Отправление из Rhodes - {rou}\n" +
                    $"Отправление из Valentine - {valen}\n" +
                    $"Отправление из Emerald - {emm}\n" +
                    $"Прибытие в Saint Denis - {sent_prib2}\n" +
                    "```"
                );
            }
            else if (radioButton3.Checked)
            {
                Clipboard.SetText(
                    "```\n" +
                    "Маршрут: Saint Denis - Emerald - Valentine - Rhodes - Saint Denis - Annesburg\n" +
                    $"Отправление из Saint Denis - {sent}\n" +
                    $"Отправление из Emerald - {emm}\n" +
                    $"Отправление из Valentine - {valen}\n" +
                    $"Отправление из Rhodes - {rou}\n" +
                    $"Отправление из Saint Denis - {sent_prib}\n" +
                    $"Прибытие в Annesburg - {ann}\n" +
                    "```"
                );
            }
            else if (radioButton4.Checked)
            {
                Clipboard.SetText(
                    "```\n" +
                    "Маршрут: Annesburg - Saint Denis - Emerald - Valentine - Rhodes - Saint Denis - Annesburg\n" +
                    $"Отправление из Annesburg - {ann}\n" +
                    $"Отправление из Saint Denis - {sent}\n" +
                    $"Отправление из Emerald - {emm}\n" +
                    $"Отправление из Valentine - {valen}\n" +
                    $"Отправление из Rhodes - {rou}\n" +
                    $"Отправление из Saint Denis - {sent_prib}\n" +
                    $"Прибытие в Annesburg - {ann_prib}\n" +
                    "```"
                );
            }
            else if (radioButton5.Checked)
            {
                Clipboard.SetText(
                    "```\n" +
                    "Маршрут: Annesburg - Saint Denis - Rhodes - Valentine - Emerald - Saint Denis - Annesburg\n" +
                    $"Отправление из Annesburg - {ann}\n" +
                    $"Отправление из Saint Denis - {sent}\n" +
                    $"Отправление из Rhodes - {rou}\n" +
                    $"Отправление из Valentine - {valen}\n" +
                    $"Отправление из Emerald - {emm}\n" +
                    $"Отправление из Saint Denis - {sent_prib}\n" +
                    $"Прибытие в Annesburg - {ann_prib2}\n" +
                    "```"
                );
            }
            else if (radioButton6.Checked)
            {
                Clipboard.SetText(
                    "```\n" +
                    "Маршрут: Annesburg - Saint Denis - Emerald - Valentine - Rhodes - Saint Denis\n" +
                    $"Отправление из Annesburg - {ann}\n" +
                    $"Отправление из Saint Denis - {sent}\n" +
                    $"Отправление из Emerald - {emm}\n" +
                    $"Отправление из Valentine - {valen}\n" +
                    $"Отправление из Rhodes - {rou}\n" +
                    $"Прибытие в Saint Denis - {sent_prib3}\n" +
                    "```"
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (DateTime.Now < DateTime.Parse(sent_prib))
                {
                    MessageBox.Show(
                        "Время маршрута еще не закончилось",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    button1.Enabled = button3.Enabled = true;

                    radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;

                    radioButton1.Checked = false;

                    comboBox1.SelectedIndex = 0;

                    label2.Text = "";

                    secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = "";
                }
            }
            else if (radioButton2.Checked)
            {
                if (DateTime.Now < DateTime.Parse(sent_prib2))
                {
                    MessageBox.Show(
                        "Время маршрута еще не закончилось",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    button1.Enabled = button3.Enabled = true;

                    radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;

                    radioButton2.Checked = false;

                    comboBox1.SelectedIndex = 0;

                    label2.Text = "";

                    secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = "";
                }
            }
            else if (radioButton3.Checked)
            {
                if (DateTime.Now < DateTime.Parse(ann))
                {
                    MessageBox.Show(
                        "Время маршрута еще не закончилось",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    button1.Enabled = button3.Enabled = true;

                    radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;

                    radioButton3.Checked = false;

                    comboBox1.SelectedIndex = 0;

                    label2.Text = "";

                    secondForm.Width -= 96;

                    secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = secondForm.label11.Text = secondForm.label12.Text = "";
                }
            }
            else if (radioButton4.Checked)
            {
                if (DateTime.Now < DateTime.Parse(ann_prib))
                {
                    MessageBox.Show(
                        "Время маршрута еще не закончилось",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    button1.Enabled = button3.Enabled = true;

                    radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;

                    radioButton4.Checked = false;

                    comboBox1.SelectedIndex = 0;

                    label2.Text = "";

                    secondForm.Width -= 192;

                    secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = secondForm.label11.Text = secondForm.label12.Text = secondForm.label13.Text = secondForm.label14.Text = "";
                }
            }
            else if (radioButton5.Checked)
            {
                if (DateTime.Now < DateTime.Parse(ann_prib2))
                {
                    MessageBox.Show(
                        "Время маршрута еще не закончилось",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    button1.Enabled = button3.Enabled = true;

                    radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;

                    radioButton5.Checked = false;

                    comboBox1.SelectedIndex = 0;

                    label2.Text = "";

                    secondForm.Width -= 192;

                    secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = secondForm.label11.Text = secondForm.label12.Text = secondForm.label13.Text = secondForm.label14.Text = "";
                }
            }
            else if (radioButton6.Checked)
            {
                if (DateTime.Now < DateTime.Parse(sent_prib3))
                {
                    MessageBox.Show(
                        "Время маршрута еще не закончилось",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    button1.Enabled = button3.Enabled = true;

                    radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;

                    radioButton6.Checked = false;

                    comboBox1.SelectedIndex = 0;

                    label2.Text = "";

                    secondForm.Width -= 96;

                    secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = secondForm.label11.Text = secondForm.label12.Text = secondForm.label13.Text = secondForm.label14.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            closeButtonClicked = true;

            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите выйти?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string fileName = "1.txt";
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                using (StreamWriter writer = new(filePath, append: true))
                {
                    writer.WriteLine("--------------------------------");
                    writer.WriteLine($"Кол-во рейсов = {m};");
                    writer.WriteLine($"Кол-во баллов = {b};");
                    writer.WriteLine($"Дата = {DateTime.Now:d} {DateTime.Now:T}");
                    writer.WriteLine("--------------------------------");
                }

                MessageBox.Show(
                    "Отчет сохранен",
                    "Сохранение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = button3.Enabled = true;
            button2.Enabled = button4.Enabled = false;

            if (radioButton1.Checked)
            {
                m -= 1;
                b -= 1;
            }
            else if (radioButton2.Checked)
            {
                m -= 1;
                b -= 1;
            }
            else if (radioButton3.Checked)
            {
                m -= 1;
                b -= 1.2;

                secondForm.Width -= 96;
            }
            else if (radioButton4.Checked)
            {
                m -= 1;
                b -= 1.35;

                secondForm.Width -= 192;
            }
            else if (radioButton5.Checked)
            {
                m -= 1;
                b -= 1.35;

                secondForm.Width -= 192;
            }
            else if (radioButton6.Checked)
            {
                m -= 1;
                b -= 1.2;

                secondForm.Width -= 96;
            }


            label2.Text = "";

            radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = radioButton6.Checked = false;
            comboBox1.SelectedIndex = 0;

            secondForm.label1.Text = secondForm.label2.Text = secondForm.label3.Text = secondForm.label4.Text = secondForm.label5.Text = secondForm.label6.Text = secondForm.label7.Text = secondForm.label8.Text = secondForm.label9.Text = secondForm.label10.Text = secondForm.label11.Text = secondForm.label12.Text = secondForm.label13.Text = secondForm.label14.Text = "";

            MessageBox.Show(
                "Запись удалена",
                "Удаление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeButtonClicked &&
                MessageBox.Show(
                    "Форма закрывается через кнопку выход",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ) == DialogResult.OK
            )
                e.Cancel = true;
        }
    }
}