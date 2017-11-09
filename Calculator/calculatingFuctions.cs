using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculatingFuctions
    {
        double num1, num2, answers;

        public calculatingFuctions( double num1, double num2, double answers)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.answers = answers;
        }

        public void additionFunction( double num1, double num2, double answers)
        {
            try
            {
                answers = num1 + num2;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void subtractionFunction( double num1, double num2, double answers)
        {
            try
            {
                answers = num1 - num2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void multiplicationFunction( double num1, double num2, double answers)
        {
            try
            {
                answers = num1 * num2;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void divisionFunction( double num1, double num2, double answers)
        {
            try
            {
                answers = num1 / num2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
