using Xunit;

namespace AnagramsSolution
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Solution.isPairAnagram("firecode", "CodEfire"));
        }

        [Fact]
        public void Test2()
        {
            Assert.False(Solution.isPairAnagram("look", "cool"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Solution.isPairAnagram("look", "coolk"));
        }
    }
}