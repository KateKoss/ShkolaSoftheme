﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;

namespace HW20
{
    class MobileAccountValidationAttr : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var mobileAccount = value as MobileAccount;
            
            if (mobileAccount != null && mobileAccount.Birthday < DateTime.Now.AddYears(-2))
            {
                try
                {
                    MailAddress m = new MailAddress(mobileAccount.Email);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
