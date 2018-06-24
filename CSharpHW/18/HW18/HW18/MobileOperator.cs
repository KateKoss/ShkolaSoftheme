using System;

namespace HW18
{
    class MobileOperator
    {
        public MobileAccount[] users;
        public string operatorName;

        public MobileOperator(string name)
        {
            operatorName = name;
        }
        
        public void CreateAccounts()
        {
            users = new MobileAccount[]
            {
                new MobileAccount("+380936186187", "Kate"),
                new MobileAccount("+380945545235", "Oleg"),
                new MobileAccount("+380636484621", "Alex"),
                new MobileAccount("+380971468468", "Lion")
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
    }
}
