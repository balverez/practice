namespace CombinationSumII
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1, 1, 6 },
                new List<int>() { 1, 2, 5 },
                new List<int>() { 1, 7 },
                new List<int>() { 2, 6 },
            };
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;

            Assert.Equal(expected, new Solution().CombinationSum2(candidates, target));
        }

        [Fact]
        public void Test2()
        {
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1, 2, 2 },
                new List<int>() { 5 }
            };
            int[] candidates = { 2, 5, 2, 1, 2 };
            int target = 5;

            Assert.Equal(expected, new Solution().CombinationSum2(candidates, target));
        }
    }
}