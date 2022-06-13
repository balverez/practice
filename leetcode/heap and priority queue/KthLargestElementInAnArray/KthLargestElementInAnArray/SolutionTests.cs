namespace KthLargestElementInAnArray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(5, new int[] { 3, 2, 1, 5, 6, 4 }, 2)]
        [InlineData(4, new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4)]
        public void Tests(int expected, int[] nums, int k) => Assert.Equal(expected, new Solution().FindKthLargest(nums, k));
    }
}