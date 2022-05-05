using Xunit;

namespace MaxProfit
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 30, 25, 20, 15 };
            int expectedResult = 0;
            Assert.Equal(expectedResult, new Solution().MaxProfit(testArr));
        }

        [Fact]
        public void Test2()
        {
            int[] testArr = new int[] { 50, 0, 10, 100 };
            int expectedResult = 100;
            Assert.Equal(expectedResult, new Solution().MaxProfit(testArr));
        }

        [Fact]
        public void Test3()
        {
            int[] testArr = new int[] { 30, 50, 10, 100 };
            int expectedResult = 90;
            Assert.Equal(expectedResult, new Solution().MaxProfit(testArr));
        }

        [Fact]
        public void Test4()
        {
            int[] testArr = new int[] { 100, 99, 98, 95 };
            int expectedResult = 0;
            Assert.Equal(expectedResult, new Solution().MaxProfit(testArr));
        }

        [Fact]
        public void Test5()
        {
            int[] testArr = new int[] { 100, 100 };
            int expectedResult = 0;
            Assert.Equal(expectedResult, new Solution().MaxProfit(testArr));
        }

        [Fact]
        public void Test6()
        {
            int[] testArr = new int[] { 102, 105, 99, 98, 102, 99 };
            int expectedResult = 4;
            Assert.Equal(expectedResult, new Solution().MaxProfit(testArr));
        }
    }
}