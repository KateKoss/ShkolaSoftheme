using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    static class UserUtil
    {
        public static void StartUserEntering(UserNumbers user)
        {
            
            //int[] numbers = new int[6];
            Console.WriteLine("Enter "+ NumberGenerator.amountNumbers + "numbers of the random number generator");
            for (int i = 0; i < NumberGenerator.amountNumbers; i++)
            {
                Console.Write("Input number" + (i + 1) + ": ");
                try
                {
                    var userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput > 0 && userInput < 10)
                    {
                        user[i] = userInput;
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong imput. Enter integer number from 1 to 9");
                    i--;
                }
            }
        }

        public static bool NumbersCorrespond(UserNumbers userNumers, NumberGenerator generator)
        {
            for (int i = 0; i < NumberGenerator.amountNumbers; i++)
            {
                if (userNumers[i] != generator[i])
                {
                    return false;
                }                
            }
            return true;
        }
    }
}
