namespace InterleavingString
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "aabcc", "dbbca", "aadbbcbcac")]
        [InlineData(false, "aabcc", "dbbca", "aadbbbaccc")]
        [InlineData(true, "", "", "")]
        public void Tests(bool expected, string s1, string s2, string s3) => Assert.Equal(expected, new Solution().IsInterleave(s1, s2, s3));
    }
}