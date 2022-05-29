namespace MaximumProductWordLengths
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(16, new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" })]
        [InlineData(4, new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" })]
        [InlineData(0, new string[] { "a", "aa", "aaa", "aaaa" })]
        public void Test(int expected, string[] words) => Assert.Equal(expected, new Solution().MaxProduct(words));
    }
}