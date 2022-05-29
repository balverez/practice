using Xunit;

namespace KWeakestRows
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[][] test = new int[][]
            {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 }
            };

            int k = 3;
            int[] expected = { 2, 0, 3 };

            Assert.Equal(expected, new Solution().KWeakestRows(test, k));
        }

        [Fact]
        public void Test2()
        {
            int[][] test = new int[][]
            {
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0 }
            };

            int k = 2;
            int[] expected = { 0, 2 };

            Assert.Equal(expected, new Solution().KWeakestRows(test, k));
        }
    }
}