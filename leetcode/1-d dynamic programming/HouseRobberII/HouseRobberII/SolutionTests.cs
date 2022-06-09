namespace HouseRobberII
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, new int[] { 2, 3, 2 })]
        [InlineData(4, new int[] { 1, 2, 3, 1 })]
        [InlineData(3, new int[] { 1, 2, 3 })]
        [InlineData(3, new int[] { 1, 2, 1, 1 })]
        [InlineData(103, new int[] { 1, 3, 1, 3, 100 })]
        [InlineData(340, new int[] { 200, 3, 140, 20, 10 })]
        [InlineData(0, new int[] { 0 })]
        public void Test(int expected, int[] nums) => Assert.Equal(expected, new Solution().Rob(nums));
    }
}