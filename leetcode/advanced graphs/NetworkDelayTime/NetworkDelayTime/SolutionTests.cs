namespace NetworkDelayTime
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 2;
            int[][] times =
            {
                new int[] { 2, 1, 1 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 4, 1 }
            };
            int n = 4;
            int k = 2;

            Assert.Equal(expected, new Solution().NetworkDelayTime(times, n, k));
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            int[][] times =
            {
                new int[] { 1, 2, 1 }
            };
            int n = 2;
            int k = 1;

            Assert.Equal(expected, new Solution().NetworkDelayTime(times, n, k));
        }

        [Fact]
        public void Test3()
        {
            int expected = -1;
            int[][] times =
            {
                new int[] { 1, 2, 1 }
            };
            int n = 2;
            int k = 2;

            Assert.Equal(expected, new Solution().NetworkDelayTime(times, n, k));
        }
    }
}