namespace TrieWordInsert
{
    internal class Solution
    {
        private Trie _trie;

        internal Solution()
        {
            _trie = new();
            _trie.Insert("FIRE");
            _trie.Insert("FIRECODE");
            _trie.Insert("FIRESIDE");
        }

        internal bool Search(string word) => _trie.Search(word);
    }
}