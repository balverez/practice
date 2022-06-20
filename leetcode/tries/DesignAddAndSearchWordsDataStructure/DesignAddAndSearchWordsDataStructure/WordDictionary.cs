namespace DesignAddAndSearchWordsDataStructure
{
    public class WordDictionary
    {
        private TrieNode _trie = new();

        //O(n) time
        //O(n) space
        public void AddWord(string word)
        {
            TrieNode node = _trie;

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new();

                node = node.Children[c];
            }

            node.IsWordBoundary = true;
        }

        public bool Search(string word) => SearchTrie(word, _trie);

        //O(26^n) time for undefined words, where n is key length.
        //O(n) space for possible recursions.
        public bool SearchTrie(string word, TrieNode node)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (!node.Children.ContainsKey(c))
                {
                    if (c == '.')
                        foreach (TrieNode child in node.Children.Values)
                            if (SearchTrie(word[(i + 1)..], child))
                                return true;

                    return false;
                }
                else
                    node = node.Children[c];
            }

            return node.IsWordBoundary;
        }
    }
}