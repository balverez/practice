using Xunit;

namespace ReverseInteger
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(153, 351)]
        [InlineData(321, 123)]
        [InlineData(21, 12)]
        [InlineData(0, 0)]
        public void Test(int expected, int test)
        {
            Assert.Equal(expected, new Solution().Reverse(test));
        }
    }
}