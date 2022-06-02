namespace SingleNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, new int[] { 2, 2, 1 })]
        [InlineData(4, new int[] { 4, 1, 2, 1, 2 })]
        [InlineData(1, new int[] { 1 })]
        public void Test(int expected, int[] test) => Assert.Equal(expected, new Solution().SingleNumber(test));
    }
}