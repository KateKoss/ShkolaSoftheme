using System;
using System.Collections.Generic;
using System.Linq;

namespace HW19
{
    class MobileAccount
    {
        public delegate void Action(MobileAccount toMobileAccount, AccountEventArgs eventArgs);
        public event Action CallSomeone;
        public event Action SentSMS;
        public string mobileNumber;
        public string name;
        public Dictionary<string,ContactInfo> contacts { get; }

        public MobileAccount(string mobileNumber, string name)
        {
            this.mobileNumber = mobileNumber;
            this.name = name;
            contacts = new Dictionary<string, ContactInfo>();
        }

        public void SendSMS(MobileAccount toMobileAccount, string message)
        {
            Console.WriteLine($"From mobile number { mobileNumber } to mobile number { toMobileAccount.mobileNumber }. Message \"{ message }\"");
            if (SentSMS != null)
            {
                SentSMS(toMobileAccount, new AccountEventArgs(mobileNumber, message));
            }
        }

        public void Call(MobileAccount toMobileAccount)
        {
            Console.WriteLine($"Calling from mobile number { mobileNumber } to number { toMobileAccount.mobileNumber }");
            if (CallSomeone != null)
            {
                CallSomeone(toMobileAccount, new AccountEventArgs(mobileNumber));
            }
        }

        public void TakeCall(string fromWhomNumber)
        {
            string fromContactName = contacts.SingleOrDefault(s => s.Key == fromWhomNumber).Value != null ? contacts[fromWhomNumber].ToString() : fromWhomNumber;
            Console.WriteLine($"Mobile account number { mobileNumber } take a call from { fromContactName }.");
        }

        public void ReceiveSMS(string fromWhomNumber, string message)
        {
            string fromContactName = contacts.SingleOrDefault(s => s.Key == fromWhomNumber).Value != null ? contacts[fromWhomNumber].ToString() : fromWhomNumber;
            Console.WriteLine($"Mobile account number { mobileNumber } received sms from { fromContactName }. Message \"{ message }\".");
        }

        public void AddContact(string mobileNumber, string name)
        {
            contacts.Add(mobileNumber, new ContactInfo(name));
        }
    }
}
