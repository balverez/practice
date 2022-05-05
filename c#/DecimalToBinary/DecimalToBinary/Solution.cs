using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    internal class Solution
    {
        public string ToBinary(int decimalNumber)
        {
            if (decimalNumber <= 1)
                return "1";

            return ToBinary(decimalNumber / 2) + (decimalNumber % 2);
        }
    }
}
