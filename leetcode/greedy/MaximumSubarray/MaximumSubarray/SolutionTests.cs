namespace MaximumSubarray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(6, new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 })]
        [InlineData(1, new int[] { 1 })]
        [InlineData(23, new int[] { 5, 4, -1, 7, 8 })]
        public void Test(int expected, int[] nums) => Assert.Equal(expected, new Solution().MaxSubArray(nums));
    }
}