namespace ImplementTrie
{
    public class Trie
    {
        private TrieNode _root;

        public Trie() => _root = new();

        //O(n) time
        //O(n) space
        public void Insert(string word)
        {
            TrieNode iterator = _root;

            foreach(char c in word)
            {
                if (!iterator.Children.ContainsKey(c))
                    iterator.Children[c] = new(c);

                iterator = iterator.Children[c];
            }

            iterator.IsWordBoundary = true;
        }

        //O(n) time
        //O(1) space
        public TrieNode? SearchPrefix(string word)
        {
            TrieNode iterator = _root;

            foreach (char c in word)
            {
                if (!iterator.Children.ContainsKey(c))
                    return null;

                iterator = iterator.Children[c];
            }

            return iterator;
        }

        //O(n) time
        //O(1) space
        public bool Search(string word)
        {
            TrieNode? result = SearchPrefix(word);

            return result != null && result.IsWordBoundary;
        }

        //O(n) time
        //O(1) space
        public bool StartsWith(string prefix)
        {
            TrieNode? result = SearchPrefix(prefix);

            return result != null;
        }
    }
}