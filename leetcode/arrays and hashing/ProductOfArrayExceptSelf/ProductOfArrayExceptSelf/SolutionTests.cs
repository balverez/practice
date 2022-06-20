namespace ProductOfArrayExceptSelf
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 24, 12, 8, 6 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 0, 0, 9, 0, 0 }, new int[] { -1, 1, 0, -3, 3 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 4, 0 })]
        public void Tests(int[] expected, int[] nums) => Assert.Equal(expected, new Solution().ProductExceptSelf(nums));
    }
}