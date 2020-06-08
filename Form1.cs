using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "1";
            }
            else
            {
                txtResults.Text = txtResults.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "2";
            }
            else
            {
                txtResults.Text = txtResults.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "3";
            }
            else
            {
                txtResults.Text = txtResults.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "4";
            }
            else
            {
                txtResults.Text = txtResults.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "5";
            }
            else
            {
                txtResults.Text = txtResults.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "6";
            }
            else
            {
                txtResults.Text = txtResults.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "7";
            }
            else
            {
                txtResults.Text = txtResults.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "8";
            }
            else
            {
                txtResults.Text = txtResults.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "9";
            }
            else
            {
                txtResults.Text = txtResults.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "0" && txtResults.Text != null)
            {
                txtResults.Text = "0";
            }
            else
            {
                txtResults.Text = txtResults.Text + "0";
            }
        }

        private void nDot_Click(object sender, EventArgs e)
        {
            txtResults.Text = txtResults.Text + "." +
                "";
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            SetForNextOperation("+");
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            SetForNextOperation("-");
        }

        private void bPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtResults.Text.Contains("-"))
                txtResults.Text = txtResults.Text.Replace("-", "");
            else
                txtResults.Text = string.Concat("-", txtResults.Text);
        }

        private void bPercent_Click(object sender, EventArgs e)
        {
            int length = txtResults.Text.Length;
            if (length > 2)
            {
                txtResults.Text = string.Format("{0}.{1}", txtResults.Text.Substring(0, length - 2), txtResults.Text.Substring(length - 2, 2));
            }
            else
            {
                if (length == 2)
                    txtResults.Text = string.Format("0.{0}", txtResults.Text);
                else
                    txtResults.Text = string.Format("0.0{0}", txtResults.Text);
            }
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            SetForNextOperation("*");
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResults.Text);
            SetForNextOperation("/");
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            txtResults.Text = "0";
        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
                
            SecondNumber = Convert.ToDouble(txtResults.Text);

            switch (Operation)
            {
                case "+":
                    Result = (FirstNumber + SecondNumber);
                    Update(Result);
                    break;
                case "-":
                    Result = (FirstNumber - SecondNumber);
                    Update(Result);
                    break;
                case "*":
                    Result = (FirstNumber * SecondNumber);
                    Update(Result);
                    break;
                case "/":
                    if (SecondNumber == 0)
                        txtResults.Text = "ERR divide by zero";
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        Update(Result);
                    }
                    break;
            }
        }

        private void SetForNextOperation(string Operator)
        {
            txtResults.Text = "0";
            Operation = Operator;
        }

        private void Update(double result)
        {
            txtResults.Text = Convert.ToString(result);
            FirstNumber = result;
        }
    }
}
