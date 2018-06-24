using System;
using System.Collections.Generic;
using System.Linq;

namespace HW19
{
    class MobileOperator
    {
        public MobileAccount[] users;
        public string operatorName;
        public List<Interaction> interactions;

        public MobileOperator(string name)
        {
            operatorName = name;
            interactions = new List<Interaction>();
        }
        
        public void CreateAccounts()
        {
            users = new MobileAccount[]
            {
                //new MobileAccount("Zerro", "Ted"),
                //new MobileAccount("One", "Kate"),
                //new MobileAccount("Two", "Oleg"),
                //new MobileAccount("three", "Alex"),
                //new MobileAccount("four", "Lion"),
                //new MobileAccount("five", "Karina")                
                new MobileAccount("+380936186187", "Kate"),
                new MobileAccount("+380945545235", "Oleg"),
                new MobileAccount("+380636484621", "Alex"),
                new MobileAccount("+380971468468", "Lion"),
                new MobileAccount("+380964894651", "Karina"),
                new MobileAccount("+380984153987", "Ted")
            };

            users[1].AddContact(users[0].mobileNumber, users[0].name);
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
            for (int i = 0; i < users.Length; i++)
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
            //var callStatistic1 = from i in interactions
            //                group i by new
            //                {
            //                    i.toMobileNumber
            //                } into gr
            //                select new
            //                {
            //                    gr.Key.toMobileNumber,
            //                    Count = gr.Sum(x => Convert.ToDecimal(x.interactionType) / 2)
            //                };
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
    }
}
