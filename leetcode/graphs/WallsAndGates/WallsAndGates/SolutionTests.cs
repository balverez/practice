namespace WallsAndGates
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[][] expected = new int[][]
            {
                new int[] { 3, -1, 0, 1 },
                new int[] { 2, 2, 1, -1 },
                new int[] { 1, -1, 2, -1 },
                new int[] { 0, -1, 3, 4 }
            };

            int[][] rooms = new int[][]
            {
                new int[] { 2147483647, -1, 0, 2147483647 },
                new int[] { 2147483647, 2147483647, 2147483647, -1 },
                new int[] { 2147483647, -1, 2147483647, -1 },
                new int[] { 0, -1, 2147483647, 2147483647 }
            };

            new Solution().WallsAndGates(rooms);
            Assert.Equal(expected, rooms);
        }

        [Fact]
        public void Test2()
        {
            int[][] expected = new int[][]
            {
                new int[] { -1 }
            };

            int[][] rooms = new int[][]
            {
                new int[] { -1 }
            };

            new Solution().WallsAndGates(rooms);
            Assert.Equal(expected, rooms);
        }
    }
}