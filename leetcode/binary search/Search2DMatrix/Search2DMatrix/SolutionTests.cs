namespace Search2DMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            int[][] matrix = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 },
            };
            int target = 3;

            Assert.Equal(expected, new Solution().SearchMatrix(matrix, target));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            int[][] matrix = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 },
            };
            int target = 13;

            Assert.Equal(expected, new Solution().SearchMatrix(matrix, target));
        }
    }
}