using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class CarConstructor
    {
        public Car Construct(string model, ushort year, Engine engine, Color color, Transmission transmission)
        {
            return new Car(model, year, engine, color, transmission);
        }
        public Car Reconstruct(Car car, Transmission transm)
        {
            car.transmission = transm;
            return car;
        }
    }
}
