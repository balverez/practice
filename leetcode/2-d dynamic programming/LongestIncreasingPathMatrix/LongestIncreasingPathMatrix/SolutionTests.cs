namespace LongestIncreasingPathMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 4;
            int[][] matrix =
            {
                new int[] { 9, 9, 4 },
                new int[] { 6, 6, 8 },
                new int[] { 2, 1, 1 }
            };

            Assert.Equal(expected, new Solution().LongestIncresingPath(matrix));
        }

        [Fact]
        public void Test2()
        {
            int expected = 4;
            int[][] matrix =
            {
                new int[] { 3, 4, 5 },
                new int[] { 3, 2, 6 },
                new int[] { 2, 2, 1 }
            };

            Assert.Equal(expected, new Solution().LongestIncresingPath(matrix));
        }

        [Fact]
        public void Test3()
        {
            int expected = 1;
            int[][] matrix =
            {
                new int[] { 1 }
            };

            Assert.Equal(expected, new Solution().LongestIncresingPath(matrix));
        }
    }
}