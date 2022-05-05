using Xunit;

namespace CsvDelimiter
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(",1,2,3,4", "_", "_1_2_3_4")]
        [InlineData(",", "_", "_")]
        [InlineData(",1,2,3,4", "__", "__1__2__3__4")]
        public void Test(string test, string replacement, string expected)
        {
            Assert.True(string.Equals(new Solution().replaceCsvDelimiter(test, replacement), expected));
        }
    }
}