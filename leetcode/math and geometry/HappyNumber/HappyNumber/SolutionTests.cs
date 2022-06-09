namespace HappyNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, 19)]
        [InlineData(true, 1)]
        [InlineData(false, 2)]
        public void Test1(bool expected, int n) => Assert.Equal(expected, new Solution().IsHappy(n));
    }
}