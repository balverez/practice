namespace SwimInRisingWater
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            int[][] grid =
            {
                new int[] { 0, 2 },
                new int[] { 1, 3 }
            };

            Assert.Equal(expected, new Solution().SwimInWater(grid));
        }

        [Fact]
        public void Test2()
        {
            int expected = 16;
            int[][] grid =
            {
                new int[] { 0, 1, 2, 3, 4 },
                new int[] { 24, 23, 22, 21, 5 },
                new int[] { 12, 13, 14, 15, 16 },
                new int[] { 11, 17, 18, 19, 20 },
                new int[] { 10, 9, 8, 7, 6 },
            };

            Assert.Equal(expected, new Solution().SwimInWater(grid));
        }

        [Fact]
        public void Test3()
        {
            int expected = 3;
            int[][] grid =
            {
                new int[] { 3, 2 },
                new int[] { 0, 1 }
            };

            Assert.Equal(expected, new Solution().SwimInWater(grid));
        }
    }
}