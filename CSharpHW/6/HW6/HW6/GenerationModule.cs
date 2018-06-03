using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class GenerationModule
    {
        public int number { get; set; }
        public int maxValue { get; set; }
        public int minValue { get; set; }
        public GenerationModule()
        {
            minValue = 1;
            maxValue = 10;            
            number = new Random().Next(minValue, maxValue);
        }
    }
}
