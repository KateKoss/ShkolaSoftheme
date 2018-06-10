using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    class NumberGenerator
    {
        public static int amountNumbers = 6;
        static int[] generatedNumbers;

        public NumberGenerator()
        {
            generatedNumbers = new int[amountNumbers];
            Random rnd = new Random();
            for (int i = 0; i < amountNumbers; i++)
            {
                this[i] = rnd.Next(1,9);
            }            
        }

        public int this[int i]
        {
            get
            {
                return generatedNumbers[i];
            }
            set
            {
                generatedNumbers[i] = value;
            }
        }

        public void ShowGeneratedNumbers()
        {
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                Console.Write(this[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
