namespace BestTimeBuySellStock
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i - 1]);
                max = Math.Max(max, prices[i] - min);
            }

            return max;
        }
    }
}