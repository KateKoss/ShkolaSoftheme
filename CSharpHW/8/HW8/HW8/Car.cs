using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Car
    {
        public string model { get; }
        public ushort year { set; get; }
        public Color color { set; get; }
        public Engine engine { set; get; }
        public Transmission transmission { set; get; }

        public Car(string model, ushort year, Color color)
        {
            this.model = model;
            this.year = year;
            this.color = color;

        }
        public Car(string model, Engine engine, Color color, Transmission transm)
        {
            this.model = model;
            this.engine = engine;
            this.color = color;
            this.transmission = transmission;
        }
        override
        public string ToString()
        {
            return "Car model: " + model + " Car year: " + year + " Car color: " + color;
        }
    }
}
