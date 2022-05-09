using Xunit;

namespace ValidParentheses
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "()[]()")]
        [InlineData(true, "(())")]
        [InlineData(false, "([)]")]
        [InlineData(false, "([]")]
        public void Test(bool expected, string test)
        {
            Assert.Equal(expected, new Solution().isValid(test));
        }
    }
}