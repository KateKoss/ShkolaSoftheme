using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW3
{
    static class ValidationRules
    {
        public static bool ContainsOnlyLetter(string str)
        {
            char[] charArray = str.ToCharArray();
            foreach (char oneChar in charArray)
            {
                if (char.IsDigit(oneChar))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ContainsOnlyNumber(string str)
        {
            char[] charArray = str.ToCharArray();
            foreach (char oneChar in charArray)
            {
                if (!char.IsDigit(oneChar))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckEmail(string emailStr)
        {
            if (string.IsNullOrEmpty(emailStr))
            {
                return false;
            }
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return emailRegex.IsMatch(emailStr);
        }

        public static bool CheckPhoneNumber(string phoneStr)
        {
            if (ContainsOnlyNumber(phoneStr) && phoneStr.Length == 12 && !string.IsNullOrEmpty(phoneStr))
            {
                return true;
            }
            return false;
        }
    }
}
