namespace JumpGameII
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(0, new int[] { 0 })]
        [InlineData(3, new int[] { 1, 1, 1, 1 })]
        [InlineData(2, new int[] { 2, 3, 1, 1, 4 })]
        [InlineData(2, new int[] { 2, 3, 0, 1, 4 })]
        [InlineData(2, new int[] { 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 })]
        public void Test(int expected, int[] nums) => Assert.Equal(expected, new Solution().Jump(nums));
    }
}