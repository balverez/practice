using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePower
{
    internal class Solution
    {
        public long SimplePower(int b, int n)
        {
            if (n == 0)
                return 1L;

            return b * SimplePower(b, n - 1);
        }
    }
}
