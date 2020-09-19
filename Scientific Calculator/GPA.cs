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
    public partial class GPA : Form
    {
        public GPA()
        {
            InitializeComponent();
        }
        private double gpa(double d)
        {

            if (d >= 85 && d <= 100)
                return 4;
            else if (d >= 80)
                return 3.66;
            else if (d >= 75)
                return 3.33;
            else if (d >= 70)
                return 3.00;
            else if (d >= 67)
                return 2.66;
            else if (d >= 64)
                return 2.33;
            else if (d >= 60)
                return 2.00;
            else if (d >= 57)
                return 1.66;
            else if (d >= 53)
                return 1.33;
            else if (d >= 50)
                return 1;
            else
                return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double m1, m2, m3, m4, m5, m6;
            double gpa1, gpa2, gpa3, gpa4, gpa6, gpa5;
            m1 = Convert.ToDouble(marks1.Text);
            gpa1=gpa(m1);
            m2 = Convert.ToDouble(marks2.Text);
            gpa2 = gpa(m2);
            m3 = Convert.ToDouble(marks3.Text);
            gpa3 = gpa(m3);
            m4 = Convert.ToDouble(marks4.Text);
            gpa4 = gpa(m4);
            m5 = Convert.ToDouble(marks5.Text);
            gpa5 = gpa(m5);
            m6 = Convert.ToDouble(marks6.Text);
            gpa6 = gpa(m6);

            double total_credithours= Convert.ToDouble(credit1.Text)+Convert.ToDouble(credit2.Text)+
                Convert.ToDouble(credit3.Text)+Convert.ToDouble(credit4.Text)
                +Convert.ToDouble(credit5.Text)+Convert.ToDouble(credit6.Text);
            double finalGPA = (gpa1 * (Convert.ToDouble(credit1.Text)) +
                gpa2 * (Convert.ToDouble(credit2.Text)) + gpa3 * (Convert.ToDouble(credit3.Text)) +
                gpa4 * (Convert.ToDouble(credit4.Text)) + gpa5 * (Convert.ToDouble(credit5.Text)) +
                gpa6 * (Convert.ToDouble(credit6.Text))) / total_credithours;

            ResultBox.Text = finalGPA.ToString();
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            marks1.Text = marks2.Text = marks3.Text = marks4.Text = marks5.Text = marks6.Text = "0";
            credit1.Text = credit2.Text = credit3.Text = credit4.Text = credit5.Text = credit6.Text = "0";
            ResultBox.Text = "0";
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
