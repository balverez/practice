using Xunit;

namespace Anagrams
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(new Solution().IsAnagram("firecode", "CodEfire"));
        }

        [Fact]
        public void Test2()
        {
            Assert.False(new Solution().IsAnagram("look", "cool"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(new Solution().IsAnagram("look", "coolk"));
        }
    }
}