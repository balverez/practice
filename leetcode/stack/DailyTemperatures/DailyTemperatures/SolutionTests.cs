namespace DailyTemperatures
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 2, 1, 1, 0, 0 }, new int[] { 73, 74, 75, 71, 69, 72, 76, 73 })]
        [InlineData(new int[] { 1, 1, 1, 0 }, new int[] { 30, 40, 50, 60 })]
        [InlineData(new int[] { 1, 1, 0 }, new int[] { 30, 60, 90 })]
        public void Tests(int[] expected, int[] temperatures) => Assert.Equal(expected, new Solution().DailyTemperatures(temperatures));
    }
}