using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_2
{
    class Human
    {
        DateTime birthDate;
        string firstName;
        string lastame;
        readonly int age;
        public Human()
        {

        }
        public Human(DateTime birthDate, string firstName, string lastame)
        {
            this.birthDate = birthDate;
            this.firstName = firstName;
            this.lastame = lastame;
        }
        public Human(DateTime birthDate, string firstName, string lastame, int age)
        {
            this.birthDate = birthDate;
            this.firstName = firstName;
            this.lastame = lastame;
            this.age = age;
        }
    }
}
