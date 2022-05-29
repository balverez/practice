namespace BestTimeBuySellStock
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(5, new int[] { 7, 1, 5, 3, 6, 4 })]
        [InlineData(0, new int[] { 7, 6, 4, 3, 1 })]
        public void Test(int expected, int[] prices) => Assert.Equal(expected, new Solution().MaxProfit(prices));
    }
}