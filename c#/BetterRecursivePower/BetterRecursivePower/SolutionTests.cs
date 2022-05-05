using System;
using Xunit;

namespace BetterRecursivePower
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int b = 2;
            int n = 3;
            double expectedResult = Math.Pow(b, n);
            Assert.Equal(expectedResult, new Solution().BetterPower(b, n));
        }

        [Fact]
        public void Test2()
        {
            int b = 3;
            int n = -1;
            double expectedResult = Math.Pow(b, n);
            Assert.Equal(expectedResult, new Solution().BetterPower(b, n));
        }

        [Fact]
        public void Test3()
        {
            int b = -3;
            int n = 3;
            double expectedResult = Math.Pow(b, n);
            Assert.Equal(expectedResult, new Solution().BetterPower(b, n));
        }

        [Fact]
        public void Test4()
        {
            int b = 2;
            int n = 4;
            double expectedResult = Math.Pow(b, n);
            Assert.Equal(expectedResult, new Solution().BetterPower(b, n));
        }

        [Fact]
        public void Test5()
        {
            int b = 2;
            int n = -4;
            double expectedResult = Math.Pow(b, n);
            Assert.Equal(expectedResult, new Solution().BetterPower(b, n));
        }
    }
}