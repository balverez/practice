namespace NumbersOfIslands
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            char[][] grid = new char[][]
            {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };

            Assert.Equal(expected, new Solution().NumIslands(grid));
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            char[][] grid = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' }
            };

            Assert.Equal(expected, new Solution().NumIslands(grid));
        }
    }
}