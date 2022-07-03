namespace TrappingRainWater
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(6, new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 })]
        [InlineData(9, new int[] { 4, 2, 0, 3, 2, 5 })]
        public void Tests(int expected, int[] height) => Assert.Equal(expected, new Solution().Trap(height));
    }
}