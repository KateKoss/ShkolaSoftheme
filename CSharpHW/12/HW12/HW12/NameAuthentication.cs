using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class NameAuthentication : IAuthenticator
    {
        public bool AuthenticateUser(IUser user)
        {
            User authenticatedUser = user as User;
            if (authenticatedUser != null)
            {
                foreach (var registeredUser in GetRegisteredUsers())
                {
                    if (authenticatedUser.EqualsByName(registeredUser))
                    {
                        if (authenticatedUser.EqualsByPassword(registeredUser))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;            
        }

        public void ValidateUserInput()
        {
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            User user = new User(userName, password, string.Empty);
            if (AuthenticateUser(user))
            {
                Console.WriteLine("Welcome!");
                user = new ContainerOfUsers().GetUserWithFullInfo(user);
                Console.WriteLine(user.GetFullInfo());
                new ContainerOfUsers().setLastLoginTime(user);
            }
            else
            {
                Console.WriteLine("Unsuccessful attempt. Try again.");
            }            
        }
    }
}
