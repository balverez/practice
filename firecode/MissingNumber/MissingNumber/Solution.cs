using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    internal class Solution
    {
        //O(n) time
        //O(1) space
        public int MissingNumber(int[] sequence) => 55 - sequence.Sum();
    }
}
