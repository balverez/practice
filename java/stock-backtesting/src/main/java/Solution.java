public class Solution {
    /**
     * Returns the maximum profit possible, given an array
     * of closing prices over multiple days.
     *
     * @param closingPrices Array of integer closing prices.
     * @return Maximum profit possible.
     */
    public int maxProfit(int[] closingPrices) {
        int max = 0;
        int diff;

        for (int i = 1; i < closingPrices.length; i++)
        {
            diff = closingPrices[i] - closingPrices[i - 1];
            if (diff > 0)
            {
                max += diff; 
            }
        }

        return max;
    }
}
