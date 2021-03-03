using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public interface ICallable
    {
        public string Call(string number)
        {
            if (number.Length == 10 && IsDigitsOnly(number))
            {
                return $"Calling... {number}";
            }
            else if (number.Length == 7 && IsDigitsOnly(number))
            {
                return $"Dialing... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }


}
