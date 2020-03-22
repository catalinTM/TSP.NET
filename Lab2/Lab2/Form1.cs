using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private double number = 0;
        private string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(operation == "plus")
            {
                number = number + Convert.ToDouble(textBox1.Text);
                textBox1.Text = number.ToString();
                operation = null;
            }
            else if (operation == "minus")
            {
                number = number - Convert.ToDouble(textBox1.Text);
                textBox1.Text = number.ToString();
                operation = null;
            }
            else if (operation == "X")
            {
                number = number * Convert.ToDouble(textBox1.Text);
                textBox1.Text = number.ToString();
                operation = null;
            }
            else if (operation == "div")
            {
                number = number / Convert.ToDouble(textBox1.Text);
                textBox1.Text = number.ToString();
                operation = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "minus";
            
            if (textBox1.Text != "")
            {
                number = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation = "plus";

            if (textBox1.Text != "")
            {
                number = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation = "div";

            if (textBox1.Text != "")
            {
                number = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "X";

            if (textBox1.Text != "")
            {
                number = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
            {
                textBox1.Text = Convert.ToString((-1) * Convert.ToDouble(textBox1.Text));
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}