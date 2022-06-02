namespace RotateImage
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[][] expected = new int[][]
            {
                new int[] { 7, 4, 1 },
                new int[] { 8, 5, 2 },
                new int[] { 9, 6, 3 }
            };

            int[][] test = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            new Solution().Rotate(test);
            Assert.Equal(expected, test);
        }
    }
}