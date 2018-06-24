using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator lifecellOperator = new MobileOperator("Lifecell");
            lifecellOperator.CreateAccounts();
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[1], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[3], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[4], "Hi! How are you?");
            lifecellOperator.users[0].SendSMS(lifecellOperator.users[4], "Hi! How are you?");
            lifecellOperator.users[2].SendSMS(lifecellOperator.users[5], "Hi! How are you?");
            lifecellOperator.users[2].SendSMS(lifecellOperator.users[4], "Hi! How are you?");
            Console.WriteLine(new string('-', 20));

            lifecellOperator.users[0].Call(lifecellOperator.users[2]);
            lifecellOperator.users[0].Call(lifecellOperator.users[4]);
            lifecellOperator.users[0].Call(lifecellOperator.users[4]);
            lifecellOperator.users[1].Call(lifecellOperator.users[4]);
            lifecellOperator.users[1].Call(lifecellOperator.users[5]);
            lifecellOperator.users[1].Call(lifecellOperator.users[1]);
            lifecellOperator.users[1].Call(lifecellOperator.users[3]);

            lifecellOperator.StatisticByReceive();
            Console.WriteLine(new string('-', 20));
            lifecellOperator.StatisticByOutput();
            Console.ReadKey();
        }
    }
}
