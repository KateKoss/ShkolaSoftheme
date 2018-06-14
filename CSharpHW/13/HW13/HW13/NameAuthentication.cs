using System;

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
                user = ContainerOfUsers.GetUserWithFullInfo(user);
                Console.WriteLine(user.GetFullInfo());
                ContainerOfUsers.setLastLoginTime(user);
            }
            else
            {
                Console.WriteLine("Unsuccessful attempt. Try again.");
            }            
        }
    }
}
