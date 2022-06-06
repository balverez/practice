namespace CombinationSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<List<int>> expected = new()
            {
                new() { 2, 2, 3 },
                new() { 7 }
            };

            int[] candidates = { 2, 3, 6, 7 };
            int target = 7;

            Assert.Equal(expected, new Solution().CombinationSum(candidates, target));
        }

        [Fact]
        public void Test2()
        {
            List<List<int>> expected = new()
            {
                new() { 2, 2, 2, 2 },
                new() { 2, 3, 3 },
                new() { 3, 5 }
            };

            int[] candidates = { 2, 3, 5 };
            int target = 8;

            Assert.Equal(expected, new Solution().CombinationSum(candidates, target));
        }

        [Fact]
        public void Test3()
        {
            List<List<int>> expected = new() { };
            int[] candidates = { 2 };
            int target = 1;

            Assert.Equal(expected, new Solution().CombinationSum(candidates, target));
        }
    }
}