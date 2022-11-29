using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double x = (double)XNumeric.Value;
            double y = (double)YNumeric.Value;
            double z = (double)ZNumeric.Value;
            double v = (double)VNumeric.Value;

            minLabel.Text = Min(Min(x, y), Min(z, v)).ToString();
        }

        double Min(double a, double b)
            => (a < b) ? a : b;
    }
}
