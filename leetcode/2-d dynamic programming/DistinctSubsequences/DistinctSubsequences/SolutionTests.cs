namespace DistinctSubsequences
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, "rabbbit", "rabbit")]
        [InlineData(5, "babgbag", "bag")]
        public void Tests(int expected, string s, string t) => Assert.Equal(expected, new Solution().NumDistinct(s, t));
    }
}