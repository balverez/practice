using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Solution
    {
        public bool IsPalindrome(int input)
        {
            int reversed = 0;
            int candidate = input;

            while (candidate != 0)
            {
                reversed = (reversed * 10) + (candidate % 10);
                candidate = candidate / 10;
            }

            return reversed == input;
        }
    }
}
