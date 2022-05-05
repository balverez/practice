using Xunit;

namespace SubArrayAverages
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 1, 3, -2, 6, 4 };
            int k = 4;
            double[] expectedResult = new double[] { 2.0, 2.75 };
            Assert.Equal(expectedResult, new Solution().Averages(testArr, k));
        }

        [Fact]
        public void Test2()
        {
            int[] testArr = new int[] { 1, 3, -2, 6, 4 };
            int k = 1;
            double[] expectedResult = new double[] { 1, 3, -2, 6, 4 };
            Assert.Equal(expectedResult, new Solution().Averages(testArr, k));
        }

        [Fact]
        public void Test3()
        {
            int[] testArr = new int[] { 1, 3, -2, 6, 4 };
            int k = 5;
            double[] expectedResult = new double[] { 2.4 };
            Assert.Equal(expectedResult, new Solution().Averages(testArr, k));
        }
    }
}