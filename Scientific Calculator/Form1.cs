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
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Get_result_Click(object sender, EventArgs e)
        {
            double result;
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            char oper = Convert.ToChar(operators.Text);
            if (oper == '+')
                result = num1 + num2;
            else if (oper == '-')
                result = num1 - num2;
            else if (oper == '*')
                result = num1 * num2;
            else if (oper == '/')
                result = num1 / num2;
            else if (oper == '%')
                result = num1 % num2;
            else
                result = 0;
            Resultbox.Text = result.ToString();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Num1.Text = "0";
            Num2.Text = "0";
            Resultbox.Text = "0";

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
