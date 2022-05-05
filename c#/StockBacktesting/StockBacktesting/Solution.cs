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
            int difference;

            for(int i = 1; i < closingPrices.Length; i++)
            {
                difference = closingPrices[i] - closingPrices[i - 1];
                if (difference > 0)
                {
                    maxProfit += difference;
                }
            }

            return maxProfit;
        }
    }
}
