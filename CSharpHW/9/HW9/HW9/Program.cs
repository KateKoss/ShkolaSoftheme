using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new CarConstructor().Construct("Audi", 2015, Engine.kk2434, Color.Yellow, Transmission.Mechanical);
            Console.WriteLine(car.ToString());
            car = new CarConstructor().Reconstruct(car,Transmission.Electromechanical);
            Console.WriteLine(car.ToString());
            Console.ReadKey();
        }
    }
}
