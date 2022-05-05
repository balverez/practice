using Xunit;

namespace CountPaths
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 2)]
        [InlineData(3, 5, 15)]
        [InlineData(4, 1, 1)]
        [InlineData(5, 3, 15)]
        [InlineData(8, 10, 11440)]
        [InlineData(18, 17, 1166803110)]
        public void Test1(int m, int n, int expected)
        {
            Assert.Equal(expected, new Solution().CountPaths(m, n));
        }
    }
}