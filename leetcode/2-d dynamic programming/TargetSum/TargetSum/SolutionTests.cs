namespace TargetSum
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(5, new int[] { 1, 1, 1, 1, 1 }, 3)]
        [InlineData(1, new int[] { 1 }, 1)]
        [InlineData(0, new int[] { 100 }, -200)]
        public void Tests(int expected, int[] nums, int target) => Assert.Equal(expected, new Solution().FindTargetSumWays(nums, target));
    }
}