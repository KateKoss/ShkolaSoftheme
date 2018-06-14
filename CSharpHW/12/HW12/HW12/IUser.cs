using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    interface IUser
    {
        string Name { get; }
        string Password { get; }
        string Email { get; }
        string GetFullInfo();
    }
}
