namespace HW12
{
    interface IAuthenticator
    {
        bool AuthenticateUser(IUser user);
        void ValidateUserInput();
    }
}
