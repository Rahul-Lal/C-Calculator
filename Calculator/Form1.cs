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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        double num1, num2, answer;
        calculatingFuctions cf = new calculatingFuctions();

        int functionChoice;
        int[] functionChoices = { 1, 2, 3, 4 };
        /*
             'functionChoice' values designation:
             * Addition = 1;
             * Subtraction = 2;
             * Multiplication = 3;
             * Division = 4;
         */

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "9";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            num1 = 0.00;
            num2 = 0.00;
            answer = 0.00;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtOutput.Text);

            try
            {
                if(functionChoice == 1)
                {
                    cf.AdditionFunction(num1, num2, answer);
                    txtOutput.Text = cf.answers.ToString();
                }
                else if(functionChoice == 2)
                {
                    cf.SubtractionFunction(num1, num2, answer);
                    txtOutput.Text = cf.answers.ToString();
                }
                else if (functionChoice == 3)
                {
                    cf.MultiplicationFunction(num1, num2, answer);
                    txtOutput.Text = cf.answers.ToString();
                }
                else if (functionChoice == 4)
                {
                    cf.DivisionFunction(num1, num2, answer);
                    txtOutput.Text = cf.answers.ToString();
                }
                else
                {
                    answer = Math.Pow(num1, num2);
                    txtOutput.Text = answer.ToString();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnEquals.Text + " is denied!" + "/n" + ex);
            }
        } 

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                functionChoice = 2;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnSubtract.Text + " is denied!" + "/n" + ex);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                functionChoice = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request of "  + btnDivide.Text + " is denied!" + "/n" + ex);
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtOutput.Text += ".";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtOutput.Text += Math.PI.ToString();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Sqrt(num1).ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtOutput.Text);
            answer = 1 / num1;
            txtOutput.Text = answer.ToString();
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Text = "";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                functionChoice = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnAddition.Text + " is denied!" + "/n" + ex);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                functionChoice = 3;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnMultiply.Text + " is denied!" + "/n" + ex);
            }
        }
    }
}
