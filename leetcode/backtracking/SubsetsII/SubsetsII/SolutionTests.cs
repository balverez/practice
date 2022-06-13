namespace SubsetsII
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
                new List<int>() { 1, 2, 2 },
                new List<int>() { 2 },
                new List<int>() { 2, 2 }
            };

            int[] nums = { 1, 2, 2 };

            Assert.Equal(expected, new Solution().SubsetsWithDup(nums));
        }

        [Fact]
        public void Test2()
        {
            List<IList<int>> expected = new()
            {
                new List<int>() {  },
                new List<int>() { 0 }
            };

            int[] nums = { 0 };

            Assert.Equal(expected, new Solution().SubsetsWithDup(nums));
        }
    }
}