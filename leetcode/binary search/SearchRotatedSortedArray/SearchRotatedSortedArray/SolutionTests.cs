namespace SearchRotatedSortedArray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [InlineData(-1, new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3)]
        [InlineData(-1, new int[] { 1 }, 0)]
        [InlineData(1, new int[] { 8, 9, 2, 3, 4 }, 9)]
        public void Tests(int expected, int[] nums, int target) => Assert.Equal(expected, new Solution().Search(nums, target));
    }
}