using Xunit;

namespace ReverseInteger
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int test = 351;
            int expectedResult = 153;
            Assert.Equal(expectedResult, new Solution().Reverse(test));
        }

        [Fact]
        public void Test2()
        {
            int test = 123;
            int expectedResult = 321;
            Assert.Equal(expectedResult, new Solution().Reverse(test));
        }

        [Fact]
        public void Test3()
        {
            int test = 12;
            int expectedResult = 21;
            Assert.Equal(expectedResult, new Solution().Reverse(test));
        }

        [Fact]
        public void Test4()
        {
            int test = 0;
            int expectedResult = 0;
            Assert.Equal(expectedResult, new Solution().Reverse(test));
        }
    }
}