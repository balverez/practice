namespace SlidingWindowMaximum
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 3, 5, 5, 6, 7 }, new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3)]
        [InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
        public void Tests(int[] expected, int[] nums, int k) => Assert.Equal(expected, new Solution().MaxSlidingWindow(nums, k));
    }
}