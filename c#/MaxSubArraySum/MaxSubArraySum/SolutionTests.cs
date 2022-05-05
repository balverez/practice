using Xunit;

namespace MaxSubArraySum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 2, 1, 5, 1, 3 };
            int k = 3;
            int expectedResult = 9;
            Assert.Equal(expectedResult, new Solution().MaxSum(testArr, k));
        }
    }
}