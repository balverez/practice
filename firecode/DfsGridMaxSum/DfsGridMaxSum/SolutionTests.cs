using Xunit;

namespace DfsGridMaxSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 29;
            int[,] grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Assert.Equal(expected, new Solution().MaxSumDfs(grid));
        }

        [Fact]
        public void Test2()
        {
            int expected = 16;
            int[,] grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            Assert.Equal(expected, new Solution().MaxSumDfs(grid));
        }

        [Fact]
        public void Test3()
        {
            int expected = 6;
            int[,] grid = new int[,] { { 1, 2, 3 } };

            Assert.Equal(expected, new Solution().MaxSumDfs(grid));
        }
    }
}