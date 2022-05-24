using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBacktesting
{
    internal class Solution
    {
        public int MaxProfit(int[] closingPrices)
        {
            int maxProfit = 0;

            for (int i = 1; i < closingPrices.Length; i++)
            {
                if (closingPrices[i - 1] < closingPrices[i])
                    maxProfit += closingPrices[i] - closingPrices[i - 1];
            }

            return maxProfit;
        }
    }
}
