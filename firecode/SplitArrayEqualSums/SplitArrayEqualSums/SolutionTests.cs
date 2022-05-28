using Xunit;

namespace SplitArrayEqualSums
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(false, new int[] { 1, 2, 4 })]
        [InlineData(true, new int[] { 1, 1 })]
        [InlineData(false, new int[] { 1 })]
        [InlineData(true, new int[] { 0 })]
        public void Test(bool expected, int[] test)
        {
            Assert.Equal(expected, new Solution().EvenSplit(test));
        }
    }
}