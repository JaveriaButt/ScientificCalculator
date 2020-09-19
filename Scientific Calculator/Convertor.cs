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
    public partial class Convertor : Form
    {
        public Convertor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, i = 0, j;

            string bin = "", oct = "", hex = "";
          
                if (textBox1.Text != "0")
                {

                    num = Convert.ToInt32(textBox1.Text);
                    //converting to binary..
                    for (i = 0; num > 0; i++)
                    {
                        bin = bin + "" + num % 2;
                        num = num / 2;
                    }
                    textBox2.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox2.Text += bin[i];
                    //converting to octal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        oct = oct + "" + num % 8;
                        num = num / 8;
                    }
                    textBox3.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox3.Text += oct[i];
                    //convertig to hexadecimal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        if (num % 16 > -1 && num % 16 < 10)
                        {
                            hex = hex + "" + num % 16;

                        }
                        else
                        {
                            hex = hex + "" + (char)(num % 16 + 55);
                        }
                        num = num / 16;
                    }
                    textBox4.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox4.Text += hex[i];
                }
                //in case of binary entry..
                else if (textBox2.Text != "0")
                {

                    bin = (textBox2.Text) + "" + '\0';

                    //converting to decimal..
                    textBox1.Text = "";
                    for (i = 0; bin[i] != '\0'; i++) ;
                    num = 0;
                    for (i = i - 1, j = 0; i >= 0; i--, j++)
                    {
                        int c, n = 1;
                        for (c = i; c > 0; c--)

                            n = n * 2;
                        num = num + (int)((bin[j] - 48) * n);

                    }
                    textBox1.Text = num.ToString();


                    //converting to octal from decimal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        oct = oct + "" + num % 8;
                        num = num / 8;
                    }
                    textBox3.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox3.Text += oct[i];
                    //convertig to hexadecimal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        if (num % 16 > -1 && num % 16 < 10)
                        {
                            hex = hex + "" + num % 16;

                        }
                        else
                        {
                            hex = hex + "" + (char)(num % 16 + 55);
                        }
                        num = num / 16;
                    }
                    textBox4.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox4.Text += hex[i];
                }
                //in case of octal entry..
                else if (textBox3.Text != "0")
                {

                    oct = (textBox3.Text) + "" + '\0';

                    //converting to decimal..
                    textBox1.Text = "";
                    for (i = 0; oct[i] != '\0'; i++) ;
                    num = 0;
                    for (i = i - 1, j = 0; i >= 0; i--, j++)
                    {
                        int c, n = 1;
                        for (c = i; c > 0; c--)

                            n = n * 8;
                        num = num + (int)((oct[j] - 48) * n);

                    }
                    textBox1.Text = num.ToString();
                    //I will attach this code in description :) 

                    //converting to binary from decimal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        bin = bin + "" + num % 2;
                        num = num / 2;
                    }
                    textBox2.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox2.Text += bin[i];
                    //convertig to hexadecimal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        if (num % 16 > -1 && num % 16 < 10)
                        {
                            hex = hex + "" + num % 16;

                        }
                        else
                        {
                            hex = hex + "" + (char)(num % 16 + 55);
                        }
                        num = num / 16;
                    }
                    textBox4.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox4.Text += hex[i];
                }
                //in case of hexadecimal entry..
                else if (textBox4.Text != "0")
                {

                    hex = (textBox4.Text) + "" + '\0';

                    //converting to decimal from hexadecimal..
                    textBox1.Text = "";
                    for (i = 0; hex[i] != '\0'; i++) ;
                    num = 0;
                    for (i = i - 1, j = 0; i >= 0; i--, j++)
                    {
                        int c, n = 1;
                        for (c = i; c > 0; c--)
                            n = n * 16;
                        if (hex[j] >= 'A' && hex[j] <= 'F')
                        {
                            num += (hex[j] - 55) * n;
                        }
                        else if (hex[j] >= 'a' && hex[j] <= 'f')
                        {
                            num += (hex[j] - 87) * n;
                        }
                        else
                            num += (hex[j] - 48) * n;

                    }
                    textBox1.Text = num.ToString();


                    //converting to octal from decimal
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        oct = oct + "" + num % 8;
                        num = num / 8;
                    }
                    textBox3.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox3.Text += oct[i];
                    //convertig to binary
                    num = Convert.ToInt32(textBox1.Text);
                    for (i = 0; num > 0; i++)
                    {
                        bin = bin + "" + (num % 2);
                        num = num / 2;
                    }
                    textBox2.Text = "";
                    for (i = i - 1; i >= 0; i--)
                        textBox2.Text += bin[i];
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "0";
        }

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new mainForm();
            this.Hide();
            f.Show();

        }
    }
}
