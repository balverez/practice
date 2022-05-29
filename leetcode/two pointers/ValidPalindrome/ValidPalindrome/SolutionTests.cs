namespace ValidPalindrome
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "A man, a plan, a canal, Panama")]
        [InlineData(false, "race a car")]
        [InlineData(true, " ")]
        [InlineData(true, ".,")]
        public void Test1(bool expected, string test) => Assert.Equal(expected, new Solution().IsPalindrome(test));
    }
}