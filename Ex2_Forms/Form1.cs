using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();

            double a = (double)StartNumeric.Value;
            double b = (double)EndNumeric.Value;
            double h = (double)StepNumeric.Value;

            if (a <= b)
            {
                ResultTextBox.Text += $"Результат вычисления функции с интервалом [{a}, {b}] (результат функции округлен до двух знаков после запятой)\n";
                ResultTextBox.Text += "\tx\ty\n";
                for (double i = a; i <= b; i += h)
                {
                    double y = f(i);
                    ResultTextBox.Text += $"\t{Math.Round(i, 2)}\t{Math.Round(y, 2)}\n";
                }
            }
            else if (a > b)
            {
                ResultTextBox.Text += $"Результат вычисления функции с интервалом [{a}, {b}] (результат функции округлен до двух знаков после запятой)\n";
                ResultTextBox.Text += "\tx\ty\n";
                for (double i = a; i >= b; i -= h)
                {
                    double y = f(i);
                    ResultTextBox.Text += $"\t{Math.Round(i, 2)}\t{Math.Round(y, 2)}\n";
                }
            }
        }

        private double f(double x)
        {
            double result = 0;

            if (Math.Abs(x) < Math.PI / 2) result = Math.Sin(x);
            else if (Math.Abs(x) >= Math.PI / 2 && Math.Abs(x) <= Math.PI) result = Math.Cos(x);
            else if (Math.Abs(x) > Math.PI) result = 0;

            return result;
        }
    }
}
