using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthFibonacciNumber
{
    internal class Solution
    {
        //O(n) time
        //O(1) space
        internal long BetterFibonacci(int n)
        {
            if (n < 1)
                return 0L;
            if (n < 2)
                return 1L;

            long fibonacci = int.MinValue;
            long first = 0L;
            long second = 1L;
            for (int i = 1; i < n; i++)
            {
                fibonacci = first + second;
                first = second;
                second = fibonacci;
            }

            return fibonacci;
        }
    }
}
