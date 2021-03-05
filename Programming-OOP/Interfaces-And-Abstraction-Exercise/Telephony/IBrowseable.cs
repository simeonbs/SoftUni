using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public interface IBrowseable
    {
        public string Browse(string url)
        {
            if (!url.Any(char.IsDigit))
            {
                return $"Browsing: {url}!";
            }
            else
            {
                return "Invalid URL!";
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
