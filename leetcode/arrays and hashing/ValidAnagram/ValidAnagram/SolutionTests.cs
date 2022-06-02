namespace ValidAnagram
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "anagram", "nagaram")]
        [InlineData(false, "rat", "car")]
        public void Test1(bool expected, string s, string t) => Assert.Equal(expected, new Solution().IsAnagram(s, t));
    }
}