using Xunit;

namespace DecimalToBinary
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "11")]
        [InlineData(5, "101")]
        [InlineData(7, "111")]
        [InlineData(10, "1010")]
        public void Test1(int test, string expected)
        {
            Assert.Equal(expected, new Solution().ToBinary(test));
        }
    }
}