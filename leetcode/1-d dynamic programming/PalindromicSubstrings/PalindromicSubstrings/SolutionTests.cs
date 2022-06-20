namespace PalindromicSubstrings
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, "abc")]
        [InlineData(6, "aaa")]
        [InlineData(15, "aaaaa")]
        public void Tests(int expected, string s) => Assert.Equal(expected, new Solution().CountSubstrings(s));
    }
}