namespace PacificAtlanticWaterFlow
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<IList<int>> expected = new()
            {
                new List<int> { 0, 4 },
                new List<int> { 1, 3 },
                new List<int> { 1, 4 },
                new List<int> { 2, 2 },
                new List<int> { 3, 0 },
                new List<int> { 3, 1 },
                new List<int> { 4, 0 }
            };
            int[][] test = new int[][]
            {
                new int[] { 1, 2, 2, 3, 5 },
                new int[] { 3, 2, 3, 4, 4 },
                new int[] { 2, 4, 5, 3, 1 },
                new int[] { 6, 7, 1, 4, 5 },
                new int[] { 5, 1, 1, 2, 4 }
            };

            Assert.Equal(expected, new Solution().PacificAtlantic(test));
        }

        [Fact]
        public void Test2()
        {
            List<IList<int>> expected = new()
            {
                new List<int> { 0, 0 },
                new List<int> { 0, 1 },
                new List<int> { 1, 0 },
                new List<int> { 1, 1 }
            };
            int[][] test = new int[][]
            {
                new int[] { 2, 1 },
                new int[] { 1, 2 }
            };

            Assert.Equal(expected, new Solution().PacificAtlantic(test));
        }
    }
}