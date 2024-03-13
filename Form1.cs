using ScottPlot;

namespace рпс3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// MessageBox.Show("button1 was clicked");
            //ScottPlot.Plot myPlot = formsPlot1.Plot;
            //double a = 9;
            //double c = 6;

            //var func1 = new Func<double, double>((x) => Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2)));
            //var func2 = new Func<double, double>((x) => -(Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2))));
            //// var func3 = new Func<double, double>((x) => Math.Sqrt(Math.Sqrt(Math.Pow(x, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2)));

            //myPlot.Add.Function(func1);
            //myPlot.Add.Function(func2);
            //formsPlot1.Refresh();

            ////double[] dataX = { 1, 2, 3, 4, 5 };
            ////double[] dataY = { 1, 4, 9, 16, 25 };

            ////myPlot.Add.Scatter(dataX, dataY);
            ///


            ScottPlot.Plot myPlot = formsPlot1.Plot;
            List<double> X = new();
            List<double> YPos = new();
            List<double> YNeg = new();

            double a = double.Parse(textBox1.Text);
            double c = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);
            double min = double.Parse(textBox4.Text);
            double max = double.Parse(textBox5.Text);

           

            for (double x = min; x <= max; x += step)
            {
                double yPos = Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2));
                double yNeg = -(Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * Math.Pow(c, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(c, 2)));


                    YNeg.Add(yNeg);
                    X.Add(x);
              

            }
            
                var scatter = myPlot.Add.Scatter(X.ToArray(), YPos.ToArray());
                var scatter2 = myPlot.Add.Scatter(X.ToArray(), YNeg.ToArray());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

