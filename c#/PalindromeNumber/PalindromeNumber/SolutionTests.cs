using Xunit;

namespace PalindromeNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1221, true)]
        [InlineData(121, true)]
        [InlineData(12, false)]
        [InlineData(0, true)]
        public void Tests(int test, bool expected)
        {
            Assert.Equal(expected, new Solution().IsPalindrome(test));
        }
    }
}