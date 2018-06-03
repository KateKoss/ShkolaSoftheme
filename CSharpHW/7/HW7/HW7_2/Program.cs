using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human firstHuman = new Human(new DateTime(1997,3,5), "Kostycheva", "Kate");
            Human secondHuman = new Human(new DateTime(1997, 4, 24), "Chernenko", "Alex");
            if (firstHuman.Equals(secondHuman))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }
            Console.ReadKey();
        }
    }
}
