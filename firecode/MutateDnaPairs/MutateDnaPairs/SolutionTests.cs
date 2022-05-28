using Xunit;

namespace MutateDnaPairs
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("AA", "AGA")]
        [InlineData("TTTT", "TGTGTGT")]
        [InlineData("TATA", "TATA")]
        public void Test(string test, string expected)
        {
            Assert.Equal(expected, new Solution().MutateDnaPairs(test));
        }
    }
}