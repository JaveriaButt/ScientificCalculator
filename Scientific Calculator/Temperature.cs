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
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp=0;
            //converting celsius to fahrehhiet and Kelvin
            if (textBox1.Text != "0")
            {
                temp = Convert.ToDouble(textBox1.Text);
                textBox2.Text = (1.8 * temp + 32).ToString();
                textBox3.Text = (temp + 273.1).ToString();
            }
            else if (textBox2.Text != "0")
            {
                temp = Convert.ToDouble(textBox2.Text);
                textBox1.Text = ((temp - 32) / 1.8).ToString();
                textBox3.Text = (Convert.ToDouble(textBox1.Text) + 273.1).ToString();
            }
            else if (textBox3.Text != "0") 
            {
                temp = Convert.ToDouble(textBox3.Text);
                textBox1.Text = (temp - 273.1).ToString();
                textBox2.Text = (1.8 * Convert.ToDouble(textBox1.Text) + 32).ToString();
            }
            else 
            textBox1.Text=textBox2.Text=textBox3.Text="0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "0";
        }

        private void closeAll(object sender, FormClosingEventArgs e)
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
