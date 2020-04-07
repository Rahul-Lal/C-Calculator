using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
	public class Calculation
    {
        public static double calculateOperation(double n1, double n2, string funct)
        {
            double answer = double.NaN;

            switch(funct)
            {
                case "+":
                    answer = n1 + n2;
                    break;
                case "-":
                    answer = n1 - n2;
                    break;
                case "x":
                    answer = n1 * n2;
                    break;
                case "/":
                    if(n2 != 0)
                        {
                        answer = n1 / n2;
                    }    
                    break;
                default:
                    break;
            }
            return answer;
        }
    }
}