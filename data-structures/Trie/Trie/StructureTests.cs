using Xunit;

namespace Trie
{
    public class StructureTests
    {

        private readonly Trie _trie = new();

        public StructureTests()
        {
            _trie.Insert("FIRE");
            _trie.Insert("FIRECODE");
            _trie.Insert("FIRESIDE");
        }

        [Theory]
        [InlineData(true, "FIRE")]
        [InlineData(true, "FIRECODE")]
        [InlineData(true, "FIRESIDE")]
        [InlineData(false, "FIRES")]
        public void Test(bool expected, string test)
        {
            Assert.Equal(expected, _trie.Search(test));
        }
    }
}