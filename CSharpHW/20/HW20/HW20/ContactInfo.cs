using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20
{
    class ContactInfo
    {
        public string name { get; set; }

        public ContactInfo(string name)
        {
            this.name = name;
        }

        override
        public string ToString()
        {
            return name;
        }
    }
}
