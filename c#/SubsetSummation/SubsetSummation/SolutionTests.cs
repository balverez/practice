using Xunit;

namespace SubsetSummation
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, new int[] { 1, 2, 3 }, 0)]
        [InlineData(true, new int[] { 1, 2, 3 }, 1)]
        [InlineData(true, new int[] { 1, 2, 3 }, 3)]
        [InlineData(true, new int[] { 1, 2, 3 }, 5)]
        [InlineData(false, new int[] { 1, 2, 3 }, 7)]
        public void Test1(bool expected, int[] testArr, int testTarget)
        {
            Assert.Equal(expected, new Solution().SubsetSum(testArr, testTarget));
        }
    }
}