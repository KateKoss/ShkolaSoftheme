using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Car
    {
        public string model { get; }
        public ushort year { set; get; }
        public string color { set; get; }

        public Car(string model, ushort year, string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;

        }
        override
        public string ToString()
        {
            return "Car model: "+ model + " Car year: " + year + " Car color: " + color;
        }
    }
}
