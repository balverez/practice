namespace FindDuplicateNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, new int[] { 1, 3, 4, 2, 2 })]
        [InlineData(3, new int[] { 3, 1, 3, 4, 2 })]
        public void Tests(int expected, int[] nums) => Assert.Equal(expected, new Solution().FindDuplicate(nums));
    }
}