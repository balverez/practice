namespace CoinChange
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, new int[] { 1, 2, 5 }, 11)]
        [InlineData(-1, new int[] { 2 }, 3)]
        [InlineData(0, new int[] { 1 }, 0)]
        [InlineData(4, new int[] { 2, 5, 10, 1 }, 27)]
        [InlineData(20, new int[] { 186, 419, 83, 408 }, 6249)]
        public void Tests(int expected, int[] coins, int amount) => Assert.Equal(expected, new Solution().CoinChange(coins, amount));
    }
}