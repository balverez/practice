using Xunit;

namespace HappyNumbers
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, 19)]
        [InlineData(false, 4)]
        public void Test(bool expected, int test) =>
            Assert.Equal(expected, new Solution().IsHappy(test));
    }
}