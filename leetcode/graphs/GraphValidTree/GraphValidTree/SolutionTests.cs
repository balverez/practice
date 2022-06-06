namespace GraphValidTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            int n = 5;
            int[][] edges =
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 0, 3 },
                new int[] { 1, 4 }
            };

            Assert.Equal(expected, new Solution().ValidTree(n, edges));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            int n = 5;
            int[][] edges =
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 1, 3 },
                new int[] { 1, 4 }
            };

            Assert.Equal(expected, new Solution().ValidTree(n, edges));
        }
    }
}