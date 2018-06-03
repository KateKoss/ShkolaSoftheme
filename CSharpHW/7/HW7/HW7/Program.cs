using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audiCar = new Car("Audi", 2005, "blue");
            Console.WriteLine(audiCar.ToString());
            TuningAtelier.TuneCar(audiCar);
            Console.WriteLine(audiCar.ToString());
            Console.ReadKey();
        }
    }
}
