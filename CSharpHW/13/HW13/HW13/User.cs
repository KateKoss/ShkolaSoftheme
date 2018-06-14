using System;

namespace HW12
{
    public class User : IUser
    {
        public string Name { get; }
        public string Password { get; }
        public string Email { get; }
        public DateTime lastLoggedInTime { get; set; }
        public User(string Name, string Password, string Email, DateTime lastLoggedInTime)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.lastLoggedInTime = lastLoggedInTime;
        }
        public User(string Name, string Password, string Email)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
        }

        public string GetFullInfo()
        {
            return string.Format("User name: {0}, Email: {1}, Last time logged in {2}", Name, Email, lastLoggedInTime);
        }

        public bool EqualsByName(User user)
        {
            return this.Name.Equals(user.Name) ;
        }
        public bool EqualsByEmail(User user)
        {
            return this.Email.Equals(user.Email);
        }
        public bool EqualsByPassword(User user)
        {
            return this.Password.Equals(user.Password);
        }
    }
}
