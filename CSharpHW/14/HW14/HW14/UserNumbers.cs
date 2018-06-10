using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    class UserNumbers
    {
        int[] userNumbers;
        public UserNumbers()
        {
            userNumbers = new int[NumberGenerator.amountNumbers];
        }

        public int this[int i]
        {
            get
            {
                return userNumbers[i];
            }
            set
            {
                userNumbers[i] = value;
            }
        }
    }
}
