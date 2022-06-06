namespace RedundantConnection
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 2, 3 };
            int[][] edges =
            {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 3 }
            };

            Assert.Equal(expected, new Solution().FindRedundantConnection(edges));
        }

        [Fact]
        public void Test2()
        {
            int[] expected = { 1, 4 };
            int[][] edges =
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 4 },
                new int[] { 1, 5 }
            };

            Assert.Equal(expected, new Solution().FindRedundantConnection(edges));
        }
    }
}