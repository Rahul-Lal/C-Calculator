using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculator
{
    class calculatingFuctions
    {
        public double answers;

        public void AdditionFunction(double num1, double num2, double answer)
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

        public void SubtractionFunction(double num1, double num2, double answer)
        {
            try
            {
                answer = num1 - num2;
                this.answers = answer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MultiplicationFunction(double num1, double num2, double answer)
        {
            try
            {
                answer = num1 * num2;
                this.answers = answer;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DivisionFunction(double num1, double num2, double answer)
        {
            try
            {
                answer = num1 / num2;
                this.answers = answer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
