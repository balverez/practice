namespace LastStoneWeight
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, new int[] { 2, 7, 4, 1, 8, 1 })]
        [InlineData(1, new int[] { 1 })]
        public void Test(int expected, int[] stones) => Assert.Equal(expected, new Solution().LastStoneWeight(stones));
    }
}