namespace HandOfStraights
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3)]
        [InlineData(false, new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(false, new int[] { 1, 1, 2, 2, 3, 3 }, 2)]
        public void Tests(bool expected, int[] hand, int groupSize) => Assert.Equal(expected, new Solution().IsNStraightHand(hand, groupSize));
    }
}