namespace MicrosoftOTS
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { 0, 0, 1, 1 }, new int[] { 1, 3, 2, 3 }, 4)]
        [InlineData(5, new int[] { 0, 0, 1, 1, 2, 2 }, new int[] { 1, 3, 2, 3, 3, 4 }, 5)]
        [InlineData(5, new int[] { 0, 1, 2, 2, 5, 5 }, new int[] { 1, 2, 3, 4, 6, 7 }, 8)]
        public void Test1(int expected, int[] A, int[] B, int N)
        {
            Assert.Equal(expected, new Solution().MaximalNetworkRank(A, B, N));
        }
    }
}