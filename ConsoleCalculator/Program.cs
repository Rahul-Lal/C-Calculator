using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
           
            bool endApp = false;

            while(!endApp)
            {
                Console.WriteLine("Hello Clarice!!!");
                // Num 1 variable
                string num1 = "";
                
                // Num 2 variable
                string num2 = "";

                // Answer variable
                double answer = 0;
                
                Console.WriteLine("Enter first number");
                num1 = Console.ReadLine();

                double cleanNum1 = 0;

                while(!double.TryParse(num1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an numerical value");
                    num1 = Console.ReadLine();
                }
                
                Console.WriteLine("Enter second number");
                num2 = Console.ReadLine();

                double cleanNum2 = 0;

                while(!double.TryParse(num2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an numerical value");
                    num1 = Console.ReadLine();
                }
                
                Console.WriteLine("Choose function +, -, x, /");
                Console.WriteLine("'+' is Addition");
                Console.WriteLine("'-' is Subraction");
                Console.WriteLine("'x' is Multiplication");
                Console.WriteLine("'/' is Division");

                string function = Console.ReadLine();

            try
             {
                    answer = c.calculateOperation( num1, num2, answer);
             }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }
                
                Console.WriteLine("Answer: " + answer.ToString());
                Console.WriteLine("Type 'exit' to close the Calculator console app...");
                
                if (Console.ReadLine() == "exit")
                {
                    endApp = true;
                }
            }
            return;
        }
    }

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
