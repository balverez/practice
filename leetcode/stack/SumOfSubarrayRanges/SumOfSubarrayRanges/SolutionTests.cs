namespace SumOfSubarrayRanges
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 1, 2, 3 })]
        [InlineData(4, new int[] { 1, 3, 3 })]
        [InlineData(59, new int[] { 4, -2, -3, 4, 1 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().SubArrayRanges(nums));
    }
}