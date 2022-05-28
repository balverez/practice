namespace TrieWordSearch
{
    internal class Solution
    {
        private Trie _trie;

        internal Solution()
        {
            _trie = new Trie();
            _trie.Insert("FIRE");
            _trie.Insert("FIRECODE");
            _trie.Insert("FIRESIDE");
        }

        internal bool Search(string word)
        {
            return _trie.Search(word);
        }
    }
}