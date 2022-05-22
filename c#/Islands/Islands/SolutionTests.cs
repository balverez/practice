using Xunit;

namespace Islands
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            int[,] test = new int[,]
            {
                { 1, 1, 1, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

            Assert.Equal(expected, new Solution().CountIslands(test));
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            int[,] test = new int[,]
            {
                { 1, 1, 1, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1 },
                { 1, 0, 0, 1, 0 }
            };

            Assert.Equal(expected, new Solution().CountIslands(test));
        }
    }
}