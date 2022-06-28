namespace ContainerWithMostWater
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(49, new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })]
        [InlineData(1, new int[] { 1, 1 })]
        public void Tests(int expected, int[] height) => Assert.Equal(expected, new Solution().MaxArea(height));
    }
}