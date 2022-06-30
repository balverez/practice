namespace EditDistance
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, "horse", "ros")]
        [InlineData(5, "intention", "execution")]
        [InlineData(1, "", "a")]
        [InlineData(1, "a", "b")]
        public void Tests(int expected, string word1, string word2) => Assert.Equal(expected, new Solution().MinDistance(word1, word2));
    }
}