using System;

namespace HW13
{
    class NameAuthentication : IAuthenticator
    {
        public bool AuthenticateUser(IUser user)
        {
            User authenticatedUser = user as User;
            if (authenticatedUser != null)
            {
                foreach (var registeredUser in ContainerOfUsers.GetRegisteredUsers())
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
                using (var db = new ContainerOfUsers())
                {
                    Console.WriteLine("Welcome!");
                    user = db.GetUserWithFullInfo(user);
                    Console.WriteLine(user.GetFullInfo());
                    db.SetLastLoginTime(user);
                }
               
            }
            else
            {
                Console.WriteLine("Unsuccessful attempt. Try again.");
            }            
        }
    }
}
