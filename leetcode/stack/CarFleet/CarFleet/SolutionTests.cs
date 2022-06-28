namespace CarFleet
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, 12, new int[] { 10, 8, 0, 5, 3 }, new int[] { 2, 4, 1, 1, 3 })]
        [InlineData(1, 10, new int[] { 3 }, new int[] { 3 })]
        [InlineData(1, 100, new int[] { 0, 2, 4 }, new int[] { 4, 2, 1 })]
        [InlineData(6, 10, new int[] { 8, 3, 7, 4, 6, 5 }, new int[] { 4, 4, 4, 4, 4, 4 })]
        [InlineData(2, 20, new int[] { 6, 2, 17 }, new int[] { 3, 9, 2 })]
        public void Tests(int expected, int target, int[] position, int[] speed) => Assert.Equal(expected, new Solution().CarFleet(target, position, speed));
    }
}