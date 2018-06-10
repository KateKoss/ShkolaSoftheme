using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = 100;            
            int[] array = new int[dimension];
            SorterUtil.FillArray(array);
            SorterUtil.PrintArray(array);

            SorterUtil.InsertionSort(array);
            Console.WriteLine("\nSorted array: ");
            SorterUtil.PrintArray(array);
            Console.ReadKey();
        }
    }
}
