namespace PermutationInString
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "ab", "eidbaooo")]
        [InlineData(false, "ab", "eidboaoo")]
        [InlineData(false, "hello", "ooolleoooleh")]
        [InlineData(true, "adc", "dcda")]
        public void Tests(bool expected, string s1, string s2) => Assert.Equal(expected, new Solution().CheckInclusion(s1, s2));
    }
}