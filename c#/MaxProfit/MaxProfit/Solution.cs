using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProfit
{
    internal class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minimum = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                minimum = Math.Min(prices[i - 1], minimum);
                maxProfit = Math.Max(prices[i] - minimum, maxProfit);
            }

            return maxProfit;
        }
    }
}
