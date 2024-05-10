using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        char op; //char for operation
        string op1 = string.Empty;
        string op2 = string.Empty;
        string input = string.Empty;
        double totalNumber = 0.0; //result
        
        //private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void text_res_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }

        private void devide_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '/';
            input = string.Empty;
        }

        private void mutiple_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '*';
            input = string.Empty;
        }

        private void substract_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '-';
            input = string.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '+';
            input = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "1";
            this.text_res.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "2";
            this.text_res.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "3";
            this.text_res.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "4";
            this.text_res.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "5";
            this.text_res.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "6";
            this.text_res.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "7";
            this.text_res.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "8";
            this.text_res.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "9";
            this.text_res.Text += input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += "0";
            this.text_res.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.text_res.Text = "";
            input += ".";
            this.text_res.Text += input;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);

            if (op == '+')
            {
                totalNumber = num1 + num2;
                text_res.Text = totalNumber.ToString();
            }
            else if (op == '-')
            {
                totalNumber = num1 - num2;
                text_res.Text = totalNumber.ToString();
            }
            else if (op == '*')
            {
                totalNumber = num1 * num2;
                text_res.Text = totalNumber.ToString();
            }
            
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    totalNumber = num1 / num2;
                    text_res.Text = totalNumber.ToString();
                }
                else
                {
                    text_res.Text = "ERROR";
                }

            }
        }

        private void remainder_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double inputValue))
            {
                inputValue = inputValue / 100;
                input = inputValue.ToString();
                text_res.Text = input;
            }
        }

        private void simbol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input) && !input.Equals("0"))
            {
                if (input.StartsWith("-"))
                {
                    input = input.Substring(1); // Remove the negative sign
                }
                else
                {
                    input = "-" + input; // Add the negative sign
                }

                text_res.Text = input;
            }
        }
    }

}
