using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class CarConstructor
    {
        public Car Construct(Engine engine, Color color, Transmission transmission)
        {
            return new Car("MyModel", engine, color, transmission);
        }
        public void Reconstruct(Car car)
        {
            car.transmission = new Transmission();
        }
    }
}
