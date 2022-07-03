namespace LongestConsecutiveSequence
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 100, 4, 200, 1, 3, 2 })]
        [InlineData(9, new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().LongestConsecutive(nums));
    }
}