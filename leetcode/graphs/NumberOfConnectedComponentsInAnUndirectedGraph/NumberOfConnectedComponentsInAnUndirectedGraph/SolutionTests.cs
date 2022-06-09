namespace NumberOfConnectedComponentsInAnUndirectedGraph
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 2;
            int n = 5;
            int[][] edges =
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            Assert.Equal(expected, new Solution().CountComponents(n, edges));
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            int n = 5;
            int[][] edges =
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 }
            };

            Assert.Equal(expected, new Solution().CountComponents(n, edges));
        }

        [Fact]
        public void Test3()
        {
            int expected = 1;
            int n = 2;
            int[][] edges =
            {
                new int[] { 1, 0 }
            };

            Assert.Equal(expected, new Solution().CountComponents(n, edges));
        }
    }
}