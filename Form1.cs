using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }

        private void divisonButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //Addition
            if(function == '+')
            {
                result = firstNum + secondNum;

                calculatorDisplay.Text = result.ToString();
            }
            //Subtraction
            if(function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Division
            if(function == '/')
            {
                if(secondNum == '0')
                {
                    calculatorDisplay.Text = "Nooo";
                }
                result = firstNum / secondNum;
                
            }
            //Multiplication
            if(function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += ".";
            calculatorDisplay.Text += userInput;
        }
    }
}
