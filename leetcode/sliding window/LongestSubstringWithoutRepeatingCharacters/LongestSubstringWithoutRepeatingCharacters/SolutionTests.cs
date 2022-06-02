namespace LongestSubstringWithoutRepeatingCharacters
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, "abcabcbb")]
        [InlineData(1, "bbbbb")]
        [InlineData(3, "pwwkew")]
        public void Test(int expected, string s) => Assert.Equal(expected, new Solution().LengthOfLongestSubstring(s));
    }
}