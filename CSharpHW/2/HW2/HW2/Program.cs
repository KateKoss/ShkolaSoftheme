using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstOperand;
            double secondOperand;
            Console.Write("Input first operand: ");
            if (double.TryParse(Console.ReadLine(), out firstOperand))
            {
                Console.Write("Input second operand: ");
                if (double.TryParse(Console.ReadLine(), out secondOperand))
                {
                    switch (getOperationNumber())
                    {
                        case 1:
                            displayResult(firstOperand + secondOperand);
                            break;
                        case 2:
                            displayResult(firstOperand - secondOperand);
                            break;
                        case 3:
                            displayResult(firstOperand * secondOperand);
                            break;
                        case 4:
                            displayResult(firstOperand / secondOperand);
                            break;
                        default:
                            Console.WriteLine("Wrong input.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
            Console.ReadKey();
        }

        public static int getOperationNumber()
        {
            Console.WriteLine("Choose operation number of operation:");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. Exit.");
            Console.Write("Number[1-5]: ");
            int operationNumber;
            if (int.TryParse(Console.ReadLine(), out operationNumber))
            {
                return operationNumber;
            }
            return 0;
        }
        public static void displayResult(double result)
        {
            Console.WriteLine("Result is: " + Math.Round(result, 2));
        }
    }
}
