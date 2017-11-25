using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double num1, num2, answer, blankVariable;
        calculatingFuctions cf = new calculatingFuctions();
        // ConvertCurrency cc = new ConvertCurrency();


        int functionChoice;
        int[] functionChoices = { 1, 2, 3, 4 };
        /*
             'functionChoice' values designation:
             * Addition = 1;
             * Subtraction = 2;
             * Multiplication = 3;
             * Division = 4;
         */

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "0";
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += ".";
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "9";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
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
                }

                txtOutput.Text = cf.answers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request of " + btnEqual.Name + " is denied!" + "/n" + ex);
            }
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Request of " + btnAddition.Name + " is denied!" + "/n" + ex);
                txtOutput.Text = "";
                num1 = blankVariable;
                num2 = blankVariable;
                answer = blankVariable;
            }
        }

        private void btnClearAll_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Request of " + btnSubtraction.Name + " is denied!" + "/n" + ex);
            }
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Request of " + btnMultiplication.Name + " is denied!" + "/n" + ex);
                txtOutput.Text = "";
                num1 = blankVariable;
                num2 = blankVariable;
                answer = blankVariable;
            }
        }

        private void btnDivison_Click(object sender, RoutedEventArgs e)
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
                MessageBox.Show("Request of " + btnDivison.Name + " is denied!" + "/n" + ex);
                txtOutput.Text = "";
                num1 = blankVariable;
                num2 = blankVariable;
                answer = blankVariable;
            }
        }
    }
}
