using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    internal class Solution
    {
        public bool IsPowerOfTwo(int n) => (n & (n - 1)) == 0;
    }
}
