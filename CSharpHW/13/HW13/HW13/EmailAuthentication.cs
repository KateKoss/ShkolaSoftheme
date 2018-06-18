using System;

namespace HW13
{
    class EmailAuthentication : IAuthenticator
    {
        public bool AuthenticateUser(IUser user)
        {
            User authenticatedUser = user as User;
            if (authenticatedUser != null)
            {
                foreach (var registeredUser in ContainerOfUsers.GetRegisteredUsers())
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
