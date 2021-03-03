using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IBrowseable
    {
        public string Browse(string url)
        {
            if (!IsDigitsOnly(url))
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
