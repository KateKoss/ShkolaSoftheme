namespace HW12
{
    interface IUser
    {
        string Name { get; }
        string Password { get; }
        string Email { get; }
        string GetFullInfo();
    }
}
