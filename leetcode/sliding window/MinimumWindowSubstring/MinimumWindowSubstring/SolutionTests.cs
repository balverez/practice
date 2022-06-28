namespace MinimumWindowSubstring
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("BANC", "ADOBECODEBANC", "ABC")]
        [InlineData("a", "a", "a")]
        [InlineData("", "a", "aa")]
        [InlineData("abc", "abc", "ac")]
        [InlineData("abc", "abc", "cba")]
        [InlineData("abbbbbcdd", "aaaaaaaaaaaabbbbbcdd", "abcdd")]
        public void Tests(string expected, string s, string t) => Assert.Equal(expected, new Solution().MinWindow(s, t));
    }
}