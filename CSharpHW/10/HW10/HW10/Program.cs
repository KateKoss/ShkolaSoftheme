using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOfRepeats arrayOfRepeats = new ArrayOfRepeats(1001);
            arrayOfRepeats.FillArray();
            arrayOfRepeats.PrintArray();
            arrayOfRepeats.InsertionSort();
            Console.WriteLine("\nSorted:");
            arrayOfRepeats.PrintArray();

            Console.WriteLine("Unique element: " + arrayOfRepeats.FindUniqueElement());
            Console.ReadKey();
        }
    }
}
