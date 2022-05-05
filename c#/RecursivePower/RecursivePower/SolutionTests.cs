using Xunit;

namespace RecursivePower
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int b = 2;
            int n = 3;
            int expectedResult = 8;
            Assert.Equal(expectedResult, new Solution().SimplePower(b, n));
        }

        [Fact]
        public void Test2()
        {
            int b = 3;
            int n = 3;
            int expectedResult = 27;
            Assert.Equal(expectedResult, new Solution().SimplePower(b, n));
        }

        [Fact]
        public void Test3()
        {
            int b = -3;
            int n = 3;
            int expectedResult = -27;
            Assert.Equal(expectedResult, new Solution().SimplePower(b, n));
        }
    }
}