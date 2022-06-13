namespace _3Sum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { -1, -1, 2},
                new List<int>() { -1, 0, 1}
            };

            int[] nums = { -1, 0, 1, 2, -1, -4 };

            Assert.Equal(expected, new Solution().ThreeSum(nums));
        }

        [Fact]
        public void Test2()
        {
            IList<IList<int>> expected = new List<IList<int>>();

            int[] nums = Array.Empty<int>();

            Assert.Equal(expected, new Solution().ThreeSum(nums));
        }

        [Fact]
        public void Test3()
        {
            IList<IList<int>> expected = new List<IList<int>>();

            int[] nums = { 0 };

            Assert.Equal(expected, new Solution().ThreeSum(nums));
        }
    }
}