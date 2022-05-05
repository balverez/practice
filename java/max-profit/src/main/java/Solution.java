public class Solution {

    /**
     * Returns the max profit achievable given an array of stock prices.
     *
     * @param prices Input array of rounded integer prices.
     * @return Maximum profit, or 0 if profit is not possible.
     */
    public int maxProfit(int[] prices) {
        int maxProfit = 0;
        int buy = Integer.MAX_VALUE;
        int buyIndex = 0;
        int sell = Integer.MIN_VALUE;
        int sellIndex = 0;

        for (int i = 0; i < prices.length; i++)
        {
            if (prices[i] < buy)
            {
                buy = prices[i];
                buyIndex = i;
                sell = Integer.MIN_VALUE;
                sellIndex = 0;
            }

            if ((prices[i] - buy) > maxProfit)
            {
                sell = prices[i];
                sellIndex = i;
            }

            if (buyIndex < sellIndex && sell - buy > maxProfit)
            {
                maxProfit = sell - buy;
            }
        }

        return maxProfit;
    }
}
