namespace MinimumIntervalToIncludeEachQuery
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 3, 3, 1, 4 };
            int[][] intervals =
            {
                new int[] { 1, 4 },
                new int[] { 2, 4 },
                new int[] { 3, 6 },
                new int[] { 4, 4 }
            };
            int[] queries = { 2, 3, 4, 5 };

            Assert.Equal(expected, new Solution().MinInterval(intervals, queries));
        }

        [Fact]
        public void Test2()
        {
            int[] expected = { 2, -1, 4, 6 };
            int[][] intervals =
            {
                new int[] { 2, 3 },
                new int[] { 2, 5 },
                new int[] { 1, 8 },
                new int[] { 20, 25 }
            };
            int[] queries = { 2, 19, 5, 22 };

            Assert.Equal(expected, new Solution().MinInterval(intervals, queries));
        }
    }
}