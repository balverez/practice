namespace UniquePaths
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(28, 3, 7)]
        [InlineData(6, 3, 3)]
        [InlineData(3, 3, 2)]
        public void Test(int expected, int m, int n) => Assert.Equal(expected, new Solution().UniquePaths(m, n));
    }
}