﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    class AccountEventArgs
    {
        public readonly string message;
        public readonly string fromWhomNumber;
        public AccountEventArgs(string fromWhomNumber)
        {
            this.fromWhomNumber = fromWhomNumber;
        }

        public AccountEventArgs(string fromWhomNumber, string message)
        {
            this.fromWhomNumber = fromWhomNumber;
            this.message = message;
        }
    }
}
