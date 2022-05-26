using Xunit;

namespace LongestSubstringUniqueCharacters
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(6, "BCEFGHBCFG")]
        [InlineData(1, "FFFFF")]
        [InlineData(5, "AAABBBABCDE")]
        public void Test(int expected, string test)
        {
            Assert.Equal(expected, new Solution().MaxSubstringLength(test));
        }
    }
}