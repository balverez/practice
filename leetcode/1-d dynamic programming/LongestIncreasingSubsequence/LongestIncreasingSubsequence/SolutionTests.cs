namespace LongestIncreasingSubsequence
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 10, 9, 2, 5, 3, 7, 101, 18 })]
        [InlineData(4, new int[] { 0, 1, 0, 3, 2, 3 })]
        [InlineData(1, new int[] { 7, 7, 7, 7, 7, 7, 7 })]
        [InlineData(6, new int[] { 3, 5, 6, 2, 5, 4, 19, 5, 6, 7, 12 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().LengthOfLIS(nums));
    }
}