using Xunit;

namespace LongestSubstringUniqueCharacters
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(6, "BCEFGHBCFG")]
        [InlineData(1, "FFFFF")]
        [InlineData(5, "AAABBBABCDE")]
        [InlineData(6, "aaaabcdnha")]
        [InlineData(10, "bce234fg5h345bcf445ghhfhsdfgfhwdw223489")]
        public void Test(int expected, string test)
        {
            Assert.Equal(expected, new Solution().MaxSubstringLength(test));
        }
    }
}