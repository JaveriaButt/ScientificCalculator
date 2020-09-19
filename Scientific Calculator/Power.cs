using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(number.Text);
            double power = Convert.ToDouble(powerP.Text);
            double res = Math.Pow(num, power);
            ResultBox.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number.Text = powerP.Text = ResultBox.Text = "0";
        }

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new mainForm();
            this.Hide();
            f.Show();
        }
    }
}
