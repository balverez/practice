namespace TopKFrequentElements
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 1, 1, 2, 2, 3 }, 2)]
        [InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
        public void Tests(int[] expected, int[] nums, int k) => Assert.Equal(expected, new Solution().TopKFrequent(nums, k));
    }
}