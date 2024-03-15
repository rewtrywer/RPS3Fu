using OpenTK.Input;
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
            button2.Enabled = false;
        }

        private void Graph()
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
                        button2.Enabled = true;
                    }
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(textBox2.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(textBox3.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8 && e.KeyChar != ',')
            {
                e.Handled = true;

            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Graph();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File2.SaveDataToFile(textBox1, textBox2, textBox3, textBox4, textBox5, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            File2.LoadDataFromFile(textBox1, textBox2, textBox3, textBox4, textBox5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

