using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class ContainerOfUsers
    {
        public static User[] users = new User[]
            {
                new User("admin", "qwerty123", "admin@gmail.com", new DateTime(2018,03,6)),
                new User("kate", "katekos", "katekos@gmail.com", new DateTime(2018,04,21)),
                new User("alex", "qwerty123", "admin@gmail.com", new DateTime(2018,03,6)),
                new User("kitty", "qwerty123", "admin@gmail.com", new DateTime(2018,03,6))
            };

        public User[] GetRegisteredUsers()
        {
            return users;
        }

        public User GetUserWithFullInfo(User user)
        {
            foreach (var registeredUser in users)
            {
                if (user.EqualsByEmail(registeredUser) || user.EqualsByName(registeredUser))
                {
                    return registeredUser;
                }
            }
            return null;
        }

        public void setLastLoginTime(User user)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (user.EqualsByEmail(users[i]) && user.EqualsByName(users[i]))
                {
                    users[i].lastLoggedInTime = DateTime.Now;
                    break;
                }
            }
        }
    }
}
