namespace Poezd
{
    public partial class Form1 : Form
    {
        private DateTime time;

        private Form2 secondForm = new();

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

            secondForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем ссылку на вторую форму
            Form2 secondForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();

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
                label9.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                sent = label9.Text;
                
                secondForm.label1.Text = "Saint Denis";
                secondForm.label2.Text = sent;

                label10.Text = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";
                emm = label10.Text;

                secondForm.label4.Text = "Emerald";
                secondForm.label3.Text = emm;

                label11.Text = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";
                valen = label11.Text;

                secondForm.label6.Text = "Valentine";
                secondForm.label5.Text = valen;

                label12.Text = $"{time.AddMinutes(16 + r).AddSeconds(-time.Second):T}";
                rou = label12.Text;

                secondForm.label8.Text = "Rhodes";
                secondForm.label7.Text = rou;

                label13.Text = $"{time.AddMinutes(18 + r).AddSeconds(-time.Second):T}";
                sent_prib = label13.Text;

                secondForm.label10.Text = "Saint Denis";
                secondForm.label9.Text = sent_prib;

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
            else if (radioButton5.Checked)
            {
                b += 1.35;
                m += 1;

                label58.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                ann = label58.Text;
                label57.Text = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";
                sent = label57.Text;
                label56.Text = $"{time.AddMinutes(10 + r).AddSeconds(-time.Second):T}";
                rou = label56.Text;
                label55.Text = $"{time.AddMinutes(15 + r).AddSeconds(-time.Second):T}";
                valen = label55.Text;
                label54.Text = $"{time.AddMinutes(19 + r).AddSeconds(-time.Second):T}";
                emm = label54.Text;
                label52.Text = $"{time.AddMinutes(22 + r).AddSeconds(-time.Second):T}";
                sent_prib = label52.Text;
                label50.Text = $"{time.AddMinutes(26 + r).AddSeconds(-time.Second):T}";
                ann_prib2 = label50.Text;

                radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton6.Enabled = false;

                button1.Enabled = button3.Enabled = false;
            }
            else if (radioButton6.Checked)
            {
                b += 1.2;
                m += 1;

                label70.Text = $"{time.AddMinutes(2 + r).AddSeconds(-time.Second):T}";
                ann = label70.Text;
                label69.Text = $"{time.AddMinutes(7 + r).AddSeconds(-time.Second):T}";
                sent = label69.Text;
                label68.Text = $"{time.AddMinutes(12 + r).AddSeconds(-time.Second):T}";
                emm = label68.Text;
                label67.Text = $"{time.AddMinutes(17 + r).AddSeconds(-time.Second):T}";
                valen = label67.Text;
                label66.Text = $"{time.AddMinutes(21 + r).AddSeconds(-time.Second):T}";
                rou = label66.Text;
                label64.Text = $"{time.AddMinutes(24 + r).AddSeconds(-time.Second):T}";
                sent_prib3 = label64.Text;

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

                    label2.Text = label9.Text = label10.Text = label11.Text = label12.Text = label13.Text = "";
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

                    label18.Text = label17.Text = label16.Text = label15.Text = label14.Text = label2.Text = "";
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

                    label2.Text = label28.Text = label27.Text = label26.Text = label25.Text = label24.Text = label34.Text = "";
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

                    label2.Text = label42.Text = label41.Text = label40.Text = label39.Text = label38.Text = label36.Text = label49.Text = "";
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

                    label2.Text = label58.Text = label57.Text = label56.Text = label55.Text = label54.Text = label52.Text = label50.Text = "";
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

                    label2.Text = label70.Text = label69.Text = label68.Text = label67.Text = label66.Text = label64.Text = "";
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
            }
            else if (radioButton4.Checked)
            {
                m -= 1;
                b -= 1.35;
            }
            else if (radioButton5.Checked)
            {
                m -= 1;
                b -= 1.35;
            }
            else if (radioButton6.Checked)
            {
                m -= 1;
                b -= 1.2;
            }


            label2.Text = "";

            radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = true;
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = radioButton6.Checked = false;
            comboBox1.SelectedIndex = 0;

            label9.Text = label10.Text = label11.Text = label12.Text = label13.Text = "";
            label18.Text = label17.Text = label16.Text = label15.Text = label14.Text = "";
            label28.Text = label27.Text = label26.Text = label25.Text = label24.Text = label34.Text = "";
            label42.Text = label41.Text = label40.Text = label39.Text = label38.Text = label36.Text = label49.Text = "";
            label58.Text = label57.Text = label56.Text = label55.Text = label54.Text = label52.Text = label50.Text = "";
            label70.Text = label69.Text = label68.Text = label67.Text = label66.Text = label64.Text = "";

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