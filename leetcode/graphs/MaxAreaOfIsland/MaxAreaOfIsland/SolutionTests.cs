namespace MaxAreaOfIsland
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 6;
            int[][] grid = new int[][]
            {
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            };

            Assert.Equal(expected, new Solution().MaxAreaOfIsland(grid));
        }

        [Fact]
        public void Test2()
        {
            int expected = 0;
            int[][] grid = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            Assert.Equal(expected, new Solution().MaxAreaOfIsland(grid));
        }
    }
}