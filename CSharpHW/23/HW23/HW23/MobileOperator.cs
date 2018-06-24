using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HW23
{
    class MobileOperator
    {
        public List<MobileAccount> users;
        public string operatorName;
        public List<Interaction> interactions;

        public MobileOperator()
        {
            interactions = new List<Interaction>();
        }

        public MobileOperator(string name)
        {
            operatorName = name;
            interactions = new List<Interaction>();
        }

        private string GenerateMobileNum()
        {
            Random rnd = new Random();
            string mobileNumber = "+380" + ((long)rnd.Next(0, 100000) * (long)rnd.Next(0, 10000)).ToString().PadLeft(9, '0');
            while (users.Any(x => x.mobileNumber.Equals(mobileNumber)))
            {
                mobileNumber = "+380" + ((long)rnd.Next(0, 100000) * (long)rnd.Next(0, 10000)).ToString().PadLeft(9, '0');
            }
            return mobileNumber;
        }

        public void AddAccount(string fName, string lName, string email, DateTime birthday)
        {
            string mobileNumber = GenerateMobileNum();
            var newAccount = new MobileAccount(mobileNumber, fName, lName, email, birthday);
            if (MobileAccount.Validate(newAccount))
            {
                users.Add(newAccount);
            }
        }

        public void CreateAccounts()
        {
            users = new List<MobileAccount>
            {              
                new MobileAccount("+380936186187", "Kate", "Kos", "kos@gmail.com", new DateTime(1997, 3, 5)),
                new MobileAccount("+380945545235", "Oleg", "Davydenko", "dav@gmail.com", new DateTime(1996, 3, 28)),
                new MobileAccount("+380636484621", "Alex", "Chevork", "cherv@gmail.com", new DateTime(1984, 11, 15)),
                new MobileAccount("+380971468468", "Lion", "Joshio", "lijosh@gmail.com", new DateTime(2000, 1, 7)),
                new MobileAccount("+380964894651", "Karina", "Fabri", "fabri@gmail.com", new DateTime(1997, 9, 5)),
                new MobileAccount("+380984153987", "Ted", "Lavrinovich", "lavr@gmail.com", new DateTime(1985, 6, 26))
            };
            users[1].AddContact(users[0].mobileNumber, users[0].FirstName);
            users[1].AddContact(users[2].mobileNumber, users[2].FirstName);
            users[1].AddContact(users[3].mobileNumber, users[3].FirstName);
            users[2].AddContact(users[0].mobileNumber, users[0].FirstName);
            users[2].AddContact(users[1].mobileNumber, users[1].FirstName);
            users[2].AddContact(users[3].mobileNumber, users[3].FirstName);
            foreach (var user in users)
            {
                user.SentSMS += RouteSMS;
                user.CallSomeone += RouteCall;
            }
        }

        public void RouteSMS(MobileAccount toMobileAccout, AccountEventArgs eventArgs)
        {
            if (ContainsAccount(toMobileAccout))
            {
                Console.WriteLine($"Sending SMS to { toMobileAccout.mobileNumber }. Message \"{ eventArgs.message }\"");
                toMobileAccout.ReceiveSMS(eventArgs.fromWhomNumber, eventArgs.message);
                interactions.Add(new Interaction(eventArgs.fromWhomNumber, toMobileAccout.mobileNumber, InteractionType.SMS));
            }
            else
            {
                Console.WriteLine("Such phone number does not exist.");
            }
        }

        public void RouteCall(MobileAccount toMobileAccout, AccountEventArgs eventArgs)
        {
            if (ContainsAccount(toMobileAccout))
            {
                Console.WriteLine($"Calling to { toMobileAccout.mobileNumber }.");
                toMobileAccout.TakeCall(eventArgs.fromWhomNumber);
                interactions.Add(new Interaction(eventArgs.fromWhomNumber, toMobileAccout.mobileNumber, InteractionType.Call));
            }
            else
            {
                Console.WriteLine("Dialed phone number does not exist.");
            }
        }

        private bool ContainsAccount(MobileAccount mobileAcc)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].mobileNumber.Equals(mobileAcc.mobileNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public void StatisticByReceive()
        {
            var callStatistic = interactions.GroupBy(x => x.toMobileNumber).Select(group => new
            {
                toMobileNumber = group.Key,
                count = group.Sum(x => Convert.ToDecimal(x.interactionType) / 2)
            }).OrderByDescending(x => x.count).Take(5);
            foreach (var item in callStatistic)
            {
                Console.WriteLine("Mobile number {0}. Weight - {1}", item.toMobileNumber, item.count);
            }
        }

        public void StatisticByOutput()
        {
            var callStatistic = interactions.GroupBy(x => x.fromMobileNumber).Select(group => new
            {
                fromMobileNumbe = group.Key,
                count = group.Sum(x => Convert.ToDecimal(x.interactionType) / 2)
            }).OrderByDescending(x => x.count).Take(5);
            foreach (var item in callStatistic)
            {
                Console.WriteLine("Mobile number {0}. Weight - {1}", item.fromMobileNumbe, item.count);
            }
        }

        public List<MobileAccount> GetUsers()
        {
            return users;
        }
    }
}
