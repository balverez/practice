namespace LargestRectangleInHistogram
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(10, new int[] { 2, 1, 5, 6, 2, 3 })]
        [InlineData(4, new int[] { 2, 4 })]
        [InlineData(3, new int[] { 2, 1, 2 })]
        public void Tests(int expected, int[] heights) => Assert.Equal(expected, new Solution().LargestRectangleArea(heights));
    }
}