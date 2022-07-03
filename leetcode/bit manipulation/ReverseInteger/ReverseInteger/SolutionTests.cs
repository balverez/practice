namespace ReverseInteger
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(321, 123)]
        [InlineData(-321, -123)]
        [InlineData(21, 120)]
        [InlineData(0, 1534236469)]
        [InlineData(2147483641, 1463847412)]
        public void Tests(int expected, int x) => Assert.Equal(expected, new Solution().Reverse(x));
    }
}