using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Solution
    {
        //O(n) time
        //O(1) space
        public bool IsPalindrome(int input)
        {
            int original = input;
            int reverse = 0;

            while (input > 0)
            {
                reverse = (reverse * 10) + (input % 10);
                input /= 10;
            }

            return reverse == original;
        }
    }
}
