namespace NonOverlappingIntervals
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            int[][] intervals =
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 3 }
            };

            Assert.Equal(expected, new Solution().EraseOverlapIntervals(intervals));
        }

        [Fact]
        public void Test2()
        {
            int expected = 2;
            int[][] intervals =
            {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 }
            };

            Assert.Equal(expected, new Solution().EraseOverlapIntervals(intervals));
        }

        [Fact]
        public void Test3()
        {
            int expected = 0;
            int[][] intervals =
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            };

            Assert.Equal(expected, new Solution().EraseOverlapIntervals(intervals));
        }
    }
}