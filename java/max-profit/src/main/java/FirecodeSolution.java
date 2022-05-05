public class FirecodeSolution {

  /**
   * Returns the max profit achievable given an array of stock prices.
   *
   * @param prices Input array of rounded integer prices.
   * @return Maximum profit, or 0 if profit is not possible.
   */
  public int maxProfit(int[] prices) {
    int maxProfit = 0;
    int minVal = prices[0];
    for (int i = 1; i < prices.length; i++) {
      minVal = Math.min(prices[i - 1], minVal);
      maxProfit = Math.max(prices[i] - minVal, maxProfit);
    }
    return maxProfit;
  }
}