namespace SpiralMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            int[][] test = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            Assert.Equal(expected, new Solution().SpiralOrder(test));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

            int[][] test = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }
            };

            Assert.Equal(expected, new Solution().SpiralOrder(test));
        }
    }
}