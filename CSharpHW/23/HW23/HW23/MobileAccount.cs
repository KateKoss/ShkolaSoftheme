using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HW23
{
    [KnownType(typeof(Dictionary<string, ContactInfo>))]
    [KnownType(typeof(ContactInfo))]
    [KnownType(typeof(string))]
    [KnownType(typeof(DateTime))]
    //[DataContract]
    [Serializable]
    [MobileAccountValidationAttr(ErrorMessage = "Wrong account info")]
    public class MobileAccount
    {
        public delegate void Action(MobileAccount toMobileAccount, AccountEventArgs eventArgs);
        [field:NonSerialized]
        public event Action CallSomeone;
        [field:NonSerialized]
        public event Action SentSMS;

        [DataMember]
        [Required]
        public string mobileNumber;

        [DataMember]
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Wrong first name length")]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Wrong last name length")]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [Required]
        public DateTime Birthday { get; set; }

        [DataMember]
        public Dictionary<string, ContactInfo> contacts { get; set; }

        public MobileAccount()
        {
            Birthday = DateTime.MinValue.ToUniversalTime();
            contacts = new Dictionary<string, ContactInfo>();
        }

        public MobileAccount(string mobileNumber, string name)
        {
            this.mobileNumber = mobileNumber;
            this.FirstName = name;
            Birthday = DateTime.MinValue.ToUniversalTime();
            contacts = new Dictionary<string, ContactInfo>();
        }

        public MobileAccount(string mobileNumber, string fName, string lName, string Email, DateTime Birthday)
        {
            this.mobileNumber = mobileNumber;
            FirstName = fName;
            LastName = lName;
            this.Email = Email;
            this.Birthday = Birthday.ToUniversalTime();
            contacts = new Dictionary<string, ContactInfo>();
        }

        public static bool Validate(MobileAccount mobileAccount)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(mobileAccount);
            if (!Validator.TryValidateObject(mobileAccount, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                return true;
            }
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
