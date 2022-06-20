namespace LongestPalindromicSubsequence
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("bab", "babad")]
        [InlineData("bb", "cbbd")]
        [InlineData("a", "ac")]
        [InlineData("bb", "abb")]
        [InlineData("tattarrattat", "tattarrattat")]
        public void Tests(string expected, string s) => Assert.Equal(expected, new Solution().LongestPalindrome(s));
    }
}