namespace DecodeWays
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, "12")]
        [InlineData(3, "226")]
        [InlineData(0, "06")]
        [InlineData(2, "11106")]
        public void Tests(int expected, string s) => Assert.Equal(expected, new Solution().NumDecodings(s));
    }
}