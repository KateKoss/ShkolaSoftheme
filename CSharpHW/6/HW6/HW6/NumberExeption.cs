using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class NumberExeption : Exception
    {
        public NumberExeption(string errorMessage, Exception innerException)
            : base(errorMessage, innerException)
        {
        }

        public NumberExeption()
            : base("Number out of generated range")
        {
        }
    }
}
