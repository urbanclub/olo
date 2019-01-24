using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Privet!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double c = Double.Parse(textBox3.Text);

            double d = b * b - 4 * a * c;
            if(d>0)
            {
                double x1 = (-b + Math.Sqrt(d) / 2 * a);
                double x2 = (-b - Math.Sqrt(d) / 2 * a);
                label4.Text = "Result: x1=" + Math.Round(x1, 2) + ", x2" + Math.Round(x2, 2);


            } else if(d ==0)
            {
                double x = (-b / (2 * a));
                label4.Text = "Result: x1=x2" + x;

            }else
            {

        
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
