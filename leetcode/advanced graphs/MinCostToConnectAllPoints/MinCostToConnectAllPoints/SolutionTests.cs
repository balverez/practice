namespace MinCostToConnectAllPoints
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 20;
            int[][] points =
            {
                new int[] { 0, 0 },
                new int[] { 2, 2 },
                new int[] { 3, 10 },
                new int[] { 5, 2 },
                new int[] { 7, 0 }
            };

            Assert.Equal(expected, new Solution().MinCostConnectPoints(points));
        }

        [Fact]
        public void Test2()
        {
            int expected = 18;
            int[][] points =
            {
                new int[] { 3, 12 },
                new int[] { -2, 5 },
                new int[] { -4, 1 }
            };

            Assert.Equal(expected, new Solution().MinCostConnectPoints(points));
        }
    }
}