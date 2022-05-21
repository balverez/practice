using Xunit;

namespace NthFibonacciNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(0, 0L)]
        [InlineData(2, 1L)]
        [InlineData(3, 2L)]
        [InlineData(4, 3L)]
        [InlineData(15, 610L)]
        [InlineData(80, 23416728348467685L)]
        public void Test(int test, long expected)
        {
            Assert.Equal(expected, new Solution().BetterFibonacci(test));
        }
    }
}