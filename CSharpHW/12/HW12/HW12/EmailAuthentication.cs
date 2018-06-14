using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class EmailAuthentication : IAuthenticator
    {
        public bool AuthenticateUser(IUser user)
        {
            User authenticatedUser = user as User;
            if (authenticatedUser != null)
            {
                foreach (var registeredUser in GetRegisteredUsers())
                {
                    if (authenticatedUser.EqualsByEmail(registeredUser))
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
            Console.Write("Enter your email: ");
            string userEmail = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            User user = new User(string.Empty, password, userEmail);
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
