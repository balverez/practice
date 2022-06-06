namespace Permutations
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<IList<int>> expected = new()
            {
                new List<int>() { 3, 2, 1 },
                new List<int>() { 2, 3, 1 },
                new List<int>() { 1, 3, 2 },
                new List<int>() { 3, 1, 2 },
                new List<int>() { 2, 1, 3 },
                new List<int>() { 1, 2, 3 }
            };
            int[] nums = { 1, 2, 3 };

            Assert.Equal(expected, new Solution().Permute(nums));
        }

        [Fact]
        public void Test2()
        {
            List<IList<int>> expected = new()
            {
                new List<int>() { 1, 0 },
                new List<int>() { 0, 1 }
            };
            int[] nums = { 0, 1 };

            Assert.Equal(expected, new Solution().Permute(nums));
        }

        [Fact]
        public void Test3()
        {
            List<IList<int>> expected = new()
            {
                new List<int>() { 1 }
            };
            int[] nums = { 1 };

            Assert.Equal(expected, new Solution().Permute(nums));
        }
    }
}