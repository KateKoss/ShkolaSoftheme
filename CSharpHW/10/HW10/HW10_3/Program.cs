using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IntArrayWrapper integers = new IntArrayWrapper(new int[] { 16, 3, 5, 21, 19, 15, 28 });
            integers.PrintArray();
            integers.Add(1);
            integers.PrintArray();
            integers.Add(65, 85, 44, 56);
            integers.PrintArray();
            Console.WriteLine("Array contains 85: " + integers.Contains(85));
            Console.WriteLine("Get value by index 6: " + integers.GetByIndex(6));
            Console.ReadKey();
        }
    }
}
