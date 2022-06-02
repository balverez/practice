namespace MinCostClimbingStairs
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(15, new int[] { 10, 15, 20 })]
        [InlineData(6, new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 })]
        public void Test1(int expected, int[] cost) => Assert.Equal(expected, new Solution().MinCostClimbingStairs(cost));
    }
}