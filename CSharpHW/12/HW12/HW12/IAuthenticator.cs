using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    interface IAuthenticator
    {
        bool AuthenticateUser(IUser user);
        void ValidateUserInput();
    }
}
