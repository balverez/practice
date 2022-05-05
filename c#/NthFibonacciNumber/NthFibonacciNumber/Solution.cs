using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthFibonacciNumber
{
    internal class Solution
    {
        public long Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n < 3)
                return 1;

            long nMinus1 = 1;
            long nMinus2 = 1;
            long result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = nMinus1 + nMinus2;
                nMinus2 = nMinus1;
                nMinus1 = result;
            }

            return result;
        }
    }
}
