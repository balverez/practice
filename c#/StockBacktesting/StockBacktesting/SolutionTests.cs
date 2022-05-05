using Xunit;

namespace StockBacktesting
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(110, new int[] {50, 100, 20, 80, 20})]
        [InlineData(50, new int[] {50, 100})]
        [InlineData(100, new int[] {50, 100, 50, 100, 50})]
        public void Test1(int expected, int[] test)
        {
            Assert.Equal(expected, new Solution().MaxProfit(test));
        }
    }
}