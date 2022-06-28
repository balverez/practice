namespace CoinChange2
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, 5, new int[] { 1, 2, 5 })]
        [InlineData(0, 3, new int[] { 2 })]
        [InlineData(1, 10, new int[] { 10 })]
        public void Tests(int expected, int amount, int[] coins) => Assert.Equal(expected, new Solution().Change(amount, coins));
    }
}