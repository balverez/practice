using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbers
{
    internal class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> observed = new();

            while (n != 1 && !observed.Contains(n))
            {
                observed.Add(n);
                n = Step(n);
            }

            return n == 1;
        }

        private int Step(int n)
        {
            double happySum = 0;

            while (n > 0)
            {
                happySum += Math.Pow((n % 10), 2);
                n /= 10;
            }

            return (int) happySum;
        }
    }
}
