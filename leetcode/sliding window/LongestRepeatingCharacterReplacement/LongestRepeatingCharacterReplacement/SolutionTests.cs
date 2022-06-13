namespace LongestRepeatingCharacterReplacement
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, "ABAB", 2)]
        [InlineData(4, "AABABBA", 1)]
        public void Tests(int expected, string s, int k) => Assert.Equal(expected, new Solution().CharacterReplacement(s, k));
    }
}