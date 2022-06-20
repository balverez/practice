namespace FindMinimumInRotatedSortedArray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, new int[] { 3, 4, 5, 1, 2 })]
        [InlineData(0, new int[] { 4, 5, 6, 7, 0, 1, 2 })]
        [InlineData(11, new int[] { 11, 13, 15, 17 })]
        [InlineData(1, new int[] { 4, 5, 1, 2, 3 })]
        [InlineData(1, new int[] { 3, 1, 2 })]
        [InlineData(1, new int[] { 1, 2 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().FindMin(nums));
    }
}