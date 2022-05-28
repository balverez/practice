using Xunit;

namespace ArrayRotation
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4 }, 1)]
        [InlineData(new int[] { 3, 4, 1, 2 }, new int[] { 1, 2, 3, 4 }, 2)]
        [InlineData(new int[] { 4, 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 }, 4)]
        [InlineData(new int[] { 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 }, 0)]
        public void Test(int[] expected, int[] test, int k)
        {
            Assert.Equal(expected, new Solution().RotateLeft(test, k));
        }
    }
}