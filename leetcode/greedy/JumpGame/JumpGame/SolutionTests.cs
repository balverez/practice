namespace JumpGame
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, new int[] { 2, 3, 1, 1, 4 })]
        [InlineData(false, new int[] { 3, 2, 1, 0, 4 })]
        [InlineData(false, new int[] { 0, 4, 2, 1, 0, 2, 0 })]
        public void Test(bool expected, int[] nums) => Assert.Equal(expected, new Solution().CanJump(nums));
    }
}