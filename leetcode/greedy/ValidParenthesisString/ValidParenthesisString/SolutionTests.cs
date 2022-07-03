namespace ValidParenthesisString
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "()")]
        [InlineData(true, "(*)")]
        [InlineData(true, "(*))")]
        [InlineData(false, "(")]
        [InlineData(false, "))((")]
        public void Tests(bool expected, string s) => Assert.Equal(expected, new Solution().CheckValidString(s));
    }
}