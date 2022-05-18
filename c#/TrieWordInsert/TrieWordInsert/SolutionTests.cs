using Xunit;

namespace TrieWordInsert
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "FIRE")]
        [InlineData(true, "FIRECODE")]
        [InlineData(true, "FIRESIDE")]
        [InlineData(false, "FIRES")]
        public void Test(bool expected, string test)
        {
            Assert.Equal(expected, new Solution().Search(test));
        }
    }
}