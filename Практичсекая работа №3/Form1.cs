using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практичсекая_работа__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            textBox4.Text = "Результаты  работы программы " + "ст. Бурковской В.О. " + Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text +
             Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text +
             Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text +
             Environment.NewLine;
            int n = 0;

            double u = Convert.ToDouble(textBox1.Text); ;
            if (radioButton1.Checked)
            {
                u = Math.Pow(Math.Exp(x), 2) + Math.Pow(y, 2) + Math.Sin(y);

            }
            else
                if (radioButton2.Checked)
            {
                u = Math.Pow((Math.Exp(x) - y), 2) + Math.Cos(y);
            }

            else
            {
                u = Math.Pow((y - Math.Exp(x)), 2) + Math.Tan(y);
            }

            textBox4.Text += "U = " + u.ToString() +
            Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
