namespace RottingOranges
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 4;
            int[][] grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 }
            };

            Assert.Equal(expected, new Solution().OrangesRotting(grid));
        }

        [Fact]
        public void Test2()
        {
            int expected = -1;
            int[][] grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 0, 1, 1 },
                new int[] { 1, 0, 1 }
            };

            Assert.Equal(expected, new Solution().OrangesRotting(grid));
        }

        [Fact]
        public void Test3()
        {
            int expected = 0;
            int[][] grid = new int[][]
            {
                new int[] { 0, 2 }
            };

            Assert.Equal(expected, new Solution().OrangesRotting(grid));
        }

        [Fact]
        public void Test4()
        {
            int expected = 2;
            int[][] grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 1, 2 }
            };

            Assert.Equal(expected, new Solution().OrangesRotting(grid));
        }
    }
}