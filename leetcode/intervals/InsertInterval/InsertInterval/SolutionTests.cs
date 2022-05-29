namespace InsertInterval
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[][] expected = new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 6, 9 }
            };

            int[][] intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 }
            };

            int[] newInterval = { 2, 5 };

            Assert.Equal(expected, new Solution().Insert(intervals, newInterval));
        }

        [Fact]
        public void Test2()
        {
            int[][] expected = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 10 },
                new int[] { 12, 16 }
            };

            int[][] intervals = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 7 },
                new int[] { 8, 10 },
                new int[] { 12, 16 }
            };

            int[] newInterval = { 4, 8 };

            Assert.Equal(expected, new Solution().Insert(intervals, newInterval));
        }
    }
}