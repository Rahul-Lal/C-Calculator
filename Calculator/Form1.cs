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

        double num1, num2, answer, blankVariable;
        calculatingFuctions cf = new calculatingFuctions();
        ConvertCurrency cc = new ConvertCurrency();


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
            try
            {
                    num2 = double.Parse(txtOutput.Text);

                    if (functionChoice == 1)
                    {
                        cf.AdditionFunction(num1, num2, answer);
                    }
                    else if (functionChoice == 2)
                    {
                        cf.SubtractionFunction(num1, num2, answer);
                    }
                    else if (functionChoice == 3)
                    {
                        cf.MultiplicationFunction(num1, num2, answer);
                    }
                    else if (functionChoice == 4)
                    {
                        cf.DivisionFunction(num1, num2, answer);
                    }
                    else
                    {
                        answer = Math.Pow(num1, num2);
                        txtOutput.Text = answer.ToString();
                    }

                txtOutput.Text = cf.answers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request of " + btnEquals.Text + " is denied!" + "/n" + ex);
            }
        } 

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != blankVariable)
                {
                    num2 = double.Parse(txtOutput.Text);
                    num1 = num1 - num2;
                    txtOutput.Text = "";
                }
                else
                {
                    num1 = double.Parse(txtOutput.Text);
                    txtOutput.Text = "";
                }

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
                if (num1 != blankVariable)
                {
                    num2 = double.Parse(txtOutput.Text);
                    num1 = num1 * num2;
                    txtOutput.Text = "";
                }
                else
                {
                    num1 = double.Parse(txtOutput.Text);
                    txtOutput.Text = "";
                }
                    functionChoice = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request of "  + btnDivide.Text + " is denied!" + "/n" + ex);
                txtOutput.Text = "";
                num1 = blankVariable;
                num2 = blankVariable;
                answer = blankVariable;
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
            try
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = Math.Sqrt(num1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Function Error: " + ex.ToString());
            }
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

        private void btnPercent_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtOutput.Text);
            answer = num1 / 100;
            txtOutput.Text = answer.ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            //Link of solution help: https://stackoverflow.com/questions/16583665/for-loop-to-calculate-factorials

            num1 = double.Parse(txtOutput.Text);
            answer = num1;

            for(int i = 1; i < num1; i++)
            {
                answer = answer * i;
            }

            txtOutput.Text = answer.ToString();
        }

        private void mnuTrigonometry_Click(object sender, EventArgs e)
        {
            if(gbxCalorie.Visible == true)
            {
                gbxCalorie.Visible = false;
            }
            else if(gbxCurrency.Visible == true)
            {
                gbxCurrency.Visible = false;
            }

            if (gbxTrigonometry.Visible == true)
            {
                gbxTrigonometry.Visible = false;
                this.Height = 391;
            }
            else
            {
                gbxTrigonometry.Visible = true;
                this.Height = 531;
            }
        }

        private void btnTangent_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                answer = Math.Tan(num1);
                txtOutput.Text = answer.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Function: " + btnTangent.Name + " crashed!");
            }
        }

        private void btnCosine_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                answer = Math.Cos(num1);
                txtOutput.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function: " + btnTangent.Name + " crashed!");
            }
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                answer = Math.Sin(num1);
                txtOutput.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function: " + btnTangent.Name + " crashed!");
            }
        }

        private void btnAsin_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                answer = Math.Asin(num1);
                txtOutput.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function: " + btnTangent.Name + " crashed!");
            }
        }

        private void btnAcos_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                answer = Math.Acos(num1);
                txtOutput.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function: " + btnTangent.Name + " crashed!");
            }
        }

        private void btnAtan_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtOutput.Text);
                answer = Math.Atan(num1);
                txtOutput.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function: " + btnTangent.Name + " crashed!");
            }
        }

        private void btnToCalories_Click(object sender, EventArgs e)
        {
            //Link to calorie to kilojoule conversion: http://www.health24.com/Diet-and-nutrition/Weight-loss/How-to-convert-calories-to-kilojoules-20120721

            num1 = double.Parse(txtOutput.Text);
            answer = num1 / 4.184;
            txtOutput.Text = answer.ToString();
        }

        private void btnToKilojoules_Click(object sender, EventArgs e)
        {
            //Link to calorie to kilojoule conversion: http://www.health24.com/Diet-and-nutrition/Weight-loss/How-to-convert-calories-to-kilojoules-20120721

            num1 = double.Parse(txtOutput.Text);
            answer = num1 * 4.184;
            txtOutput.Text = answer.ToString();
        }
        
        private void mnuCalories_Click(object sender, EventArgs e)
        {
            if(gbxTrigonometry.Visible == true)
            {
                gbxTrigonometry.Visible = false;
            }
            else if (gbxCurrency.Visible == true)
            {
                gbxCurrency.Visible = false;
            }

            if (gbxCalorie.Visible == true)
            {
                gbxCalorie.Visible = false;
                this.Height = 391;
            }
            else
            {
                gbxCalorie.Visible = true;
                this.Height = 531;
            }
        }

        private void mnuCurrency_Click(object sender, EventArgs e)
        {

            if(gbxTrigonometry.Visible == true)
            {
                gbxTrigonometry.Visible = false;
                gbxCurrency.Visible = true;
                this.Height = 531;
            }
            else if (gbxCalorie.Visible == true)
            {
                gbxCalorie.Visible = false;
                gbxCurrency.Visible = true;
                this.Height = 531;
            }
            else if (gbxCurrency.Visible == true)
            {
                gbxCurrency.Visible = false;
                this.Height = 391;
            }
            else
            {
                gbxCurrency.Visible = true;
                this.Height = 531;
            }


        }
        
        private void btnCurrencyConvert_Click(object sender, EventArgs e)
        {
            if(cbxFromCurrency.Text == "New Zealand Dollar (NZD)")
            {
                MessageBox.Show("Cannot convert the same currency");
            }
            else if(cbxFromCurrency.Text == "United States Dollar (USD)")
            {
                cc.ToNZD(double.Parse(txtOutput.Text), cbxFromCurrency.Text, cbxToCurrency.Text);
                txtOutput.Text = cc.ToMoney.ToString();
            }
            else if (cbxFromCurrency.Text == "United Arab Emirates Dirham (AED)")
            {
                cc.ToNZD(double.Parse(txtOutput.Text), cbxFromCurrency.Text, cbxToCurrency.Text);
                txtOutput.Text = cc.ToMoney.ToString();
            }
            else if (cbxFromCurrency.Text == "British Pound  (GBP)")
            {
                cc.ToNZD(double.Parse(txtOutput.Text), cbxFromCurrency.Text, cbxToCurrency.Text);
                txtOutput.Text = cc.ToMoney.ToString();
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != blankVariable)
                {
                    num2 = double.Parse(txtOutput.Text);
                    num1 = num1 + num2;
                    txtOutput.Text = "";
                }
                else
                {
                    num1 = double.Parse(txtOutput.Text);
                    txtOutput.Text = "";
                }
                    functionChoice = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnAddition.Name + " is denied!" + "/n" + ex);
                txtOutput.Text = "";
                num1 = blankVariable;
                num2 = blankVariable;
                answer = blankVariable;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != blankVariable)
                {
                    num2 = double.Parse(txtOutput.Text);
                    num1 = num1 * num2;
                    txtOutput.Text = "";
                }
                else
                {
                    num1 = double.Parse(txtOutput.Text);
                    txtOutput.Text = "";
                }
                    functionChoice = 3;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnMultiply.Text + " is denied!" + "/n" + ex);
                txtOutput.Text = "";
                num1 = blankVariable;
                num2 = blankVariable;
                answer = blankVariable;
            }
        }
    }
}
