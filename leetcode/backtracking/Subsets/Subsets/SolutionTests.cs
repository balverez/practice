namespace Subsets
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<IList<int>> expected = new()
            {
                new List<int>() {  },
                new List<int>() { 1 },
                new List<int>() { 1, 2 },
                new List<int>() { 1, 2, 3 },
                new List<int>() { 1, 3 },
                new List<int>() { 2 },
                new List<int>() { 2, 3 },
                new List<int>() { 3 }
            };

            int[] test = { 1, 2, 3 };

            Assert.Equal(expected, new Solution().Subsets(test));
        }

        [Fact]
        public void Test2()
        {
            List<List<int>> expected = new()
            {
                new() {  },
                new() { 0 }
            };

            int[] test = { 0 };

            Assert.Equal(expected, new Solution().Subsets(test));
        }
    }
}