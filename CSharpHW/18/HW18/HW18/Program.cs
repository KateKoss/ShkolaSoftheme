using System;
using System.Collections;

namespace HW18
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator lifecellOperator = new MobileOperator("Lifecell");
            lifecellOperator.CreateAccounts();
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[1], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(new MobileAccount("+380154684648", "Peter"), "Hi! How are you?");

            Console.WriteLine(new string('-', 20));

            lifecellOperator.users[1].Call(lifecellOperator.users[2]);
            lifecellOperator.users[1].Call(new MobileAccount("+380154684648", "Peter"));
            Console.ReadKey();
        }
    }
}
