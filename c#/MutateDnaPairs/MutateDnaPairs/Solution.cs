using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutateDnaPairs
{
    internal class Solution
    {
        public string MutateDnaPairs(string sequence)
        {
            if (sequence.Length < 2)
                return sequence;


            return sequence[0]
                + (sequence[0] == sequence[1] ? "G" : string.Empty)
                + MutateDnaPairs(sequence[1..]);
        }
    }
}
