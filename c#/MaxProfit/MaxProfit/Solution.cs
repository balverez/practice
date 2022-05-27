using System;

namespace MaxProfit
{
    internal class Solution
    {
        internal int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minimum = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                minimum = Math.Min(minimum, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minimum);
            }

            return maxProfit;
        }
    }
}