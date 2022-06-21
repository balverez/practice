namespace MaximumProductSubarray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(6, new int[] { 2, 3, -2, 4 })]
        [InlineData(0, new int[] { -1, 0, -1 })]
        [InlineData(25, new int[] { 2, -1, 5, 5 })]
        [InlineData(50, new int[] { 2, -1, 5, 5, -1 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().MaxProduct(nums));
    }
}