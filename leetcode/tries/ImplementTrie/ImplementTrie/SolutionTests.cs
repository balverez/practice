namespace ImplementTrie
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            Trie trie = new();
            
            trie.Insert("apple");
            Assert.True(trie.Search("apple"));
            Assert.False(trie.Search("app"));

            Assert.True(trie.StartsWith("app"));
            
            trie.Insert("app");
            Assert.True(trie.Search("app"));
        }
    }
}