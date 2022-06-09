namespace SetMatrixZeroes
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[][] expected =
            {
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 0, 1 }
            };

            int[][] matrix =
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 }
            };

            new Solution().SetZeroes(matrix);
            Assert.Equal(expected, matrix);
        }

        [Fact]
        public void Test2()
        {
            int[][] expected =
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 4, 5, 0 },
                new int[] { 0, 3, 1, 0 }
            };

            int[][] matrix =
            {
                new int[] { 0, 1, 2, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 }
            };

            new Solution().SetZeroes(matrix);
            Assert.Equal(expected, matrix);
        }
    }
}