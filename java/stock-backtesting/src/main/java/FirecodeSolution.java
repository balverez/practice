public class FirecodeSolution {
  /**
   * Returns the maximum profit possible, given an array
   * of closing prices over multiple days.
   *
   * @param closingPrices Array of integer closing prices.
   * @return Maximum profit possible.
   */
  public int maxProfit(int[] closingPrices) {
    int profit = 0;
    for (int i = 1; i < closingPrices.length; i++) {
      int twoDayProfit = closingPrices[i] - closingPrices[i - 1];
      if (twoDayProfit > 0) {
        profit += twoDayProfit;
      }
    }
    return Math.max(profit, 0);
  }
}