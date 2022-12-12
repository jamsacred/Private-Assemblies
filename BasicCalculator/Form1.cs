using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            cbOperator.SelectedIndex = 0;
            txtTotal.Text = "Total" + Environment.NewLine + "000000";
        }

        private void btnCompute_Click_1(object sender, EventArgs e)
        {
            float number1, number2;
            if (!float.TryParse(txtNumber1.Text, out number1))
            {
                MessageBox.Show("First Number is Invalid");
                return;
            }
            if (!float.TryParse(txtNumber2.Text, out number2))
            {
                MessageBox.Show("Second Number is Invalid");
                return;
            }

            string oper = cbOperator.Text;
            switch (oper)
            {
                case "+":
                    BasicCalculator.BasicCompute add = new BasicCalculator.BasicCompute();
                    txtTotal.Text = "Total" + Environment.NewLine 
                        + Convert.ToString(add.Addition(Convert.ToInt16(txtNumber1.Text), 
                        Convert.ToInt16(txtNumber2.Text)));
                    break;

                case "-":
                    BasicCalculator.BasicCompute subtract = new BasicCalculator.BasicCompute();
                    txtTotal.Text = "Total" + Environment.NewLine + Convert.ToString(subtract.Subtraction
                        (Convert.ToInt16(txtNumber1.Text), Convert.ToInt16(txtNumber2.Text)));
                    break;

                case "*":
                    BasicCalculator.BasicCompute multiply = new BasicCalculator.BasicCompute();
                    txtTotal.Text = "Total" + Environment.NewLine + Convert.ToString(multiply.Multiplication
                        (Convert.ToInt16(txtNumber1.Text), Convert.ToInt16(txtNumber2.Text)));
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Division by 'Zero'");
                    }
                    else
                    {
                        BasicCalculator.BasicCompute divide = new BasicCalculator.BasicCompute();
                        txtTotal.Text = "Total" + Environment.NewLine + Convert.ToString(divide.Division
                            (Convert.ToInt16(txtNumber1.Text), Convert.ToInt16(txtNumber2.Text)));
                    }
                    break;

                default:
                    MessageBox.Show("Operator is Invalid");
                    break;
            }
        }
    }
}