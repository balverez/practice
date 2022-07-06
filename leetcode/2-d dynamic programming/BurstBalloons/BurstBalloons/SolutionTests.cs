namespace BurstBalloons
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(167, new int[] { 3, 1, 5, 8 })]
        [InlineData(10, new int[] { 1, 5 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().MaxCoins(nums));
    }
}