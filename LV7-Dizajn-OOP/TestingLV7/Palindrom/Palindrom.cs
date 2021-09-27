using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    public class Palindrom
    {
        public String Convert(String value)
        {
            if (value == null) throw new ArgumentException();
            String output = value.ToLower().Replace(" ", "").Replace("*", "").Replace(",", "").Replace(".", "");
            return Reverse(output);
        }

        private String Reverse(String value)
        {
            char[] charArray = value.ToArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }

        public bool CheckPalindrome(String value)
        {
            if (value == null) throw new ArgumentException();

            if (value.ToLower().Replace(" ", "").Replace("*", "").Replace(",", "").Replace(".", "") == Convert(value)) return true;
            else return false;

        }
    }
}
