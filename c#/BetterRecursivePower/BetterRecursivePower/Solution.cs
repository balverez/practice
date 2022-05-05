using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRecursivePower
{
    internal class Solution
    {
        public double BetterPower(double b, int n)
        {
            if (n == 0)
                return 1D;

            if (n % 2 == 0)
                return n < 0
                    ? BetterPower(1 / (b * b), -n / 2)
                    : BetterPower(b * b, n / 2);
            else
                return n < 0
                    ? BetterPower(1 / b, -n)
                    : b * BetterPower(b, --n);
        }
    }
}
