namespace BestTimeToBuySellStockWithCooldown
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, new int[] { 1, 2, 3, 0, 2 })]
        [InlineData(0, new int[] { 1 })]
        public void Test(int expected, int[] prices) => Assert.Equal(expected, new Solution().MaxProfit(prices));
    }
}