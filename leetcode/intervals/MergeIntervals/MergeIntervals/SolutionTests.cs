namespace MergeIntervals
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[][] expected =
            {
                new int[] { 1, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };

            int[][] intervals =
            {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };

            Assert.Equal(expected, new Solution().Merge(intervals));
        }

        [Fact]
        public void Test2()
        {
            int[][] expected =
            {
                new int[] { 1, 5 }
            };

            int[][] intervals =
            {
                new int[] { 1, 4 },
                new int[] { 4, 5 }
            };

            Assert.Equal(expected, new Solution().Merge(intervals));
        }
    }
}