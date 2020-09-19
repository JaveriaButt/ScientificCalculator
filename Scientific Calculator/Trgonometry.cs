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
    public partial class Trgonometry : Form
    {
        public Trgonometry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            double res = 0;
            if(FunctionBox.Text=="cos")
            {
                double angle = (3.1416 / 180) * Convert.ToDouble(AngleBox.Text);
                res = Math.Cos(angle);
                ResultBox.Text = res.ToString();
            }
            else if (FunctionBox.Text == "cos")
            {
                double angle = (3.1416 / 180) * Convert.ToDouble(AngleBox.Text);
                res = Math.Cos(angle);
                ResultBox.Text = res.ToString();
            }
            else if (FunctionBox.Text == "sin")
            {
                double angle = (3.1416 / 180) * Convert.ToDouble(AngleBox.Text);
                res = Math.Sin(angle);
                ResultBox.Text = res.ToString();
            }
            else if (FunctionBox.Text == "tan")
            {
                double angle = (3.1416 / 180) * Convert.ToDouble(AngleBox.Text);
                res = Math.Tan(angle);
                ResultBox.Text = res.ToString();
            }
            else if (FunctionBox.Text == "cos-1")
            {
                double angle =Convert.ToDouble(AngleBox.Text);
                res = Math.Acos(angle);
                res = res * (180 / 3.1416);
                ResultBox.Text = res.ToString();
            }
            else if (FunctionBox.Text == "sin-1")
            {
                double angle =  Convert.ToDouble(AngleBox.Text);
                res = Math.Asin(angle);
                res = res * (180 / 3.1416);
                ResultBox.Text = res.ToString();
            }
            else if (FunctionBox.Text == "tan-1")
            {
                double angle = Convert.ToDouble(AngleBox.Text);
                res = Math.Atan(angle);
                res = res * (180 / 3.1416);
                ResultBox.Text = res.ToString();
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            AngleBox.Text = ResultBox.Text = "0";
        }

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new mainForm();
            this.Hide();
            f.Show();
        }
    }
}
