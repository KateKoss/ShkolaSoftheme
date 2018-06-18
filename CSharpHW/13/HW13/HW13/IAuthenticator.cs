namespace HW13
{
    interface IAuthenticator
    {
        bool AuthenticateUser(IUser user);
        void ValidateUserInput();
    }
}
