namespace HouseRobber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 1, 2, 3, 1 })]
        [InlineData(12, new int[] { 2, 7, 9, 3, 1 })]
        [InlineData(4, new int[] { 2, 1, 1, 2 })]
        public void Test(int expected, int[] nums) => Assert.Equal(expected, new Solution().Rob(nums));
    }
}