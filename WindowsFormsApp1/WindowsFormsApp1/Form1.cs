using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;
        char operation;
        double equals = 0.0;

        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void zero_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "0";
            this.display.Text += input;
        }

       
        private void one_Click_1(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "1";
            this.display.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "2";
            this.display.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "3";
            this.display.Text += input;
        }
        
        private void four_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "4";
            this.display.Text += input;
        }


        private void five_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "5";
            this.display.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "6";
            this.display.Text += input;
        }
        
        private void seven_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "7";
            this.display.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "8";
            this.display.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "9";
            this.display.Text += input;
        }

       private void add_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                firstNumber = input;
                operation = '+';
                input = string.Empty;
            }
           
            else if (operation == '-')
            {
                operation = '+';
                input = string.Empty;
            }
            else if (operation == '*')
            {
                operation = '+';
                input = string.Empty;
            }
            else if (operation == '/')
            {
                operation = '+';
                input = string.Empty;
            }
            else
            {

            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                firstNumber = input;
                operation = '/';
                input = string.Empty;
            }
            else if (operation == '-')
            {
                operation = '/';
                input = string.Empty;
            }
            else if (operation == '+')
            {
                operation = '/';
                input = string.Empty;
            }
            else if (operation == '*')
            {
                operation = '/';
                input = string.Empty;
            }
            else
            {
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += ".";
            this.display.Text += input;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                firstNumber = input;
                operation = '*';
                input = string.Empty;
            }
            else if (operation == '+')
            {
                operation = '*';
                input = string.Empty;
            }
            else if (operation == '-')
            {
                operation = '*';
                input = string.Empty;
            }
            else if (operation == '/')
            {
                operation = '*';
                input = string.Empty;
            }
            else
            {
                
            }
        }
        private void subtract_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                firstNumber = input;
                operation = '-';
                input = string.Empty;
            }
            else if (operation == '+')
            {
                operation = '-';
                input = string.Empty;
            }
            else if (operation == '/')
            {
                operation = '-';
                input = string.Empty;
            }
            else if (operation == '*')
            {
                operation = '-';
                input = string.Empty;
            }
            else
            {
               
            }
        
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            this.input = string.Empty;
            this.firstNumber = string.Empty;
            this.secondNumber = string.Empty;
        }

        private void result_Click(object sender, EventArgs e)
        {
            secondNumber = input;
            double num1, num2;
            double.TryParse(firstNumber, out num1);
            double.TryParse(secondNumber, out num2);

            this.display.Text = "";
            this.input = string.Empty;
            this.secondNumber = string.Empty;


            if (operation == '+')
            {

                equals = num1 + num2;
                display.Text = equals.ToString();
                input = equals.ToString();
            }
            else if (operation == '-')
            {
                equals = num1 - num2;
                display.Text = equals.ToString();
                input = equals.ToString();
            }
            else if (operation == '*')
            {
                equals = num1 * num2;
                display.Text = equals.ToString();
                input = equals.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    equals = num1 / num2;
                    display.Text = equals.ToString();
                    input = equals.ToString();
                }
                else
                {
                    display.Text = "CANNOT DIVIDE BY ZERO";
                }
            }
    }


    }
}
