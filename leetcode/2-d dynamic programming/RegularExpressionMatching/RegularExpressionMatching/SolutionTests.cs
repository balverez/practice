namespace RegularExpressionMatching
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(false, "aa", "a")]
        [InlineData(true, "aa", "a*")]
        [InlineData(true, "ab", ".*")]
        [InlineData(true, "aab", "c*a*b*")]
        public void Tests(bool expected, string s, string p) => Assert.Equal(expected, new Solution().IsMatch(s, p));
    }
}