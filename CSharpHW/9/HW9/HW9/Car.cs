using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    struct Car
    {
        public string model { get; }
        public ushort year { set; get; }
        public Color color { set; get; }
        public Engine engine { set; get; }
        public Transmission transmission { set; get; }

        public Car(string model, ushort year, Engine engine, Color color, Transmission transmission)
        {
            this.model = model;
            this.year = year;
            this.engine = engine;
            this.color = color;
            this.transmission = transmission;
        }
        override
        public string ToString()
        {
            return "Car model: " + model + " Car year: " + year + " Car color: " + color + " Car transmission: " + transmission;
        }
    }
}
