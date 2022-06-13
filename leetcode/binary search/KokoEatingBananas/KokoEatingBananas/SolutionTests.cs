namespace KokoEatingBananas
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 3, 6, 7, 11 }, 8)]
        [InlineData(30, new int[] { 30, 11, 23, 4, 20 }, 5)]
        [InlineData(23, new int[] { 30, 11, 23, 4, 20 }, 6)]
        [InlineData(3, new int[] { 805306368, 805306368, 805306368 }, 1000000000)]
        public void Tests(int expected, int[] piles, int h) => Assert.Equal(expected, new Solution().MinEatingSpeed(piles, h));
    }
}