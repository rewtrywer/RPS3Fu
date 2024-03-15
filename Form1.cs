using ScottPlot;
using ScottPlot.Rendering.RenderActions;
using System.Windows.Forms;

namespace рпс3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            ScottPlot.Plot myPlot = formsPlot1.Plot;
            List<double> X = new();
            List<double> YPos = new();
            List<double> YNeg = new();

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text)
                || String.IsNullOrWhiteSpace(textBox4.Text) || String.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Заполнены не все поля данных для расчёта");
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double c = double.Parse(textBox2.Text);
                double step = double.Parse(textBox3.Text);
                double min = double.Parse(textBox4.Text);
                double max = double.Parse(textBox5.Text);

                myPlot.Clear();

                if (min >= max)
                {
                    MessageBox.Show("Левая граница должна быть меньше правой");
                }
                else
                {
                    if (step <= 0)
                    {
                        MessageBox.Show("Шаг должен быть больше 0");
                    }
                    else
                    {
                        for (double x = min; x <= max; x += step)
                        {
                            double yPos = Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2));
                            double yNeg = -(Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2)));

                            if ((Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) >= 0 && (Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2) >= 0)))
                            {
                                YPos.Add(yPos);
                                YNeg.Add(yNeg);
                                X.Add(x);

                                dataGridView1.Rows.Add(x, yPos, yNeg);
                            }
                        }

                        var scatter = myPlot.Add.Scatter(X.ToArray(), YPos.ToArray());
                        var scatter2 = myPlot.Add.Scatter(X.ToArray(), YNeg.ToArray());
                        scatter.MarkerSize = 0;
                        scatter2.MarkerSize = 0;
                        formsPlot1.Refresh();
                    }
                }
            }
        }

        //private void SaveDataToFile()
        //{
        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "Text File|*.txt";
        //    saveFileDialog1.Title = "Save to Text File";
        //    saveFileDialog1.CheckFileExists = false;
        //    saveFileDialog1.CheckPathExists = true;

        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        string filePath = saveFileDialog1.FileName;

        //        using (StreamWriter writer = new StreamWriter(filePath))
        //        {
        //            writer.WriteLine(textBox1.Text);
        //            writer.WriteLine(textBox2.Text);
        //            writer.WriteLine(textBox3.Text);
        //            writer.WriteLine(textBox4.Text);
        //            writer.WriteLine(textBox5.Text);

        //            foreach (DataGridViewRow row in dataGridView1.Rows)
        //            {
        //                foreach (DataGridViewCell cell in row.Cells)
        //                {
        //                    writer.Write(cell.Value);
        //                    writer.Write("\t"); // Добавляем разделитель, например, табуляцию
        //                }
        //                writer.WriteLine(); // Переходим на новую строку после записи строки таблицы
        //            }
        //        }

        //        MessageBox.Show("Данные из таблички успешно сохранены в файл: " + filePath);
        //    }
        //}

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(textBox2.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8 && e.KeyChar != ',')
            {
                e.Handled = true;

            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File2.SaveDataToFile(textBox1, textBox2, textBox3, textBox4, textBox5, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            File2.LoadDataFromFile(textBox1, textBox2, textBox3, textBox4, textBox5);
        }
    }
}

