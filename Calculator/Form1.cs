using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //Initialising variables
        string input = "0";
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double intResult = 0.0;
        char charOperator;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Button Event Handlers
        private void buttonOpAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            charOperator = '+';
            input = "0";
        }

        private void buttonOpSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            charOperator = '-';
            input = "0";
        }

        private void buttonOpMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            charOperator = '*';
            input = "0";
        }

        private void buttonOpDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            charOperator = '/';
            input = "0";
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            numberClicked(0);
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            numberClicked(1);
        }
        
        private void buttonNum2_Click(object sender, EventArgs e)
        {
            numberClicked(2);
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            numberClicked(3);
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            numberClicked(4);
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            numberClicked(5);
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            numberClicked(6);
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            numberClicked(7);
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            numberClicked(8);
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            numberClicked(9);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
       
        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (charOperator == '+')
            {
                intResult = num1 + num2;
                textBox1.Text = intResult.ToString();
            }
            else if (charOperator == '-')
            {
                intResult = num1 - num2;
                textBox1.Text = intResult.ToString();
            }
            else if (charOperator == '*')
            {
                intResult = num1 * num2;
                textBox1.Text = intResult.ToString();
            }
            else if (charOperator == '/')
            {
                if (num2 != 0)
                {
                    intResult = num1 / num2;
                    textBox1.Text = intResult.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
            input = "0";
        }

        //methods
        //adds numbers to input string
        private void numberClicked(int number)
        {
            this.textBox1.Text = "";
            if (input == "0"){ input = number.ToString(); }
            else{ input += number; }
            this.textBox1.Text += input;
        }
    }
}
