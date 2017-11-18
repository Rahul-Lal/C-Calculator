double blankVariable;

public void ThreeValuePlusAddition(double num1, double num2, double answer)
{
    try
    {
        answer = num1 + num2;
        this.answers = answer;
    }
    catch (Exception ex)
    {
        throw ex;
    }
}

private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if ((num1 != num3) && (num2 != num3))
                {
                    num3 = double.Parse(txtOutput.Text);

                    if (functionChoice == 1)
                    {
                        answer = num1 + num3;
                        txtOutput.Text = answer.ToString();
                    }
                    else if (functionChoice == 2)
                    {
                        answer = answer + num3;
                        txtOutput.Text = answer.ToString();
                    }
                    else if (functionChoice == 3)
                    {
                        answer = answer + num3;
                        txtOutput.Text = answer.ToString();
                    }
                    else if (functionChoice == 4)
                    {
                        answer = answer + num3;
                        txtOutput.Text = answer.ToString();
                    }

                }
                else
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
                }

                txtOutput.Text = cf.answers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request of " + btnEquals.Text + " is denied!" + "/n" + ex);
            }
        }

   
private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 != blankVariable)
                {
                    num2 = double.Parse(txtOutput.Text);

                    if (functionChoice == 1)
                    {
                        //cf.AdditionFunction(num1, num2, answer);
                        num1 = answer;
                        txtOutput.Text = "";
                        functionChoice = 1;
                    }
                    else if (functionChoice == 2)
                    {
                        //cf.SubtractionFunction(num1, num2, answer);
                        num1 = answer;
                        txtOutput.Text = "";
                        functionChoice = 1;
                    }
                    else if (functionChoice == 3)
                    {
                        //cf.MultiplicationFunction(num1, num2, answer);
                        num1 = answer;
                        txtOutput.Text = "";
                        functionChoice = 1;
                    }
                    else if (functionChoice == 4)
                    {
                        //cf.DivisionFunction(num1, num2, answer);
                        num1 = answer;
                        txtOutput.Text = "";
                        functionChoice = 1;
                    }
                }
                else
                {
                    num1 = double.Parse(txtOutput.Text);
                    txtOutput.Text = "";
                    functionChoice = 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Request of " + btnAddition.Name + " is denied!" + "/n" + ex);
            }
        }