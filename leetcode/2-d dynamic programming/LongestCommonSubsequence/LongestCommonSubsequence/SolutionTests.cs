namespace LongestCommonSubsequence
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, "abcbdab", "bdcaba")]
        [InlineData(3, "abcde", "ace")]
        [InlineData(3, "abc", "abc")]
        [InlineData(0, "abc", "def")]
        public void Test(int expected, string text1, string text2) => Assert.Equal(expected, new Solution().LongestCommonSubsequence(text1, text2));
    }
}