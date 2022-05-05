using Xunit;

namespace PowerOfTwo
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, 2)]
        [InlineData(false, 5)]
        public void Test(bool expected, int test)
        {
            Assert.Equal(expected, new Solution().IsPowerOfTwo(test));
        }
    }
}