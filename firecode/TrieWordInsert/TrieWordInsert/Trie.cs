namespace TrieWordInsert
{
    internal class Trie
    {
        private TrieNode _root = new TrieNode(null);

        public void Insert(string word)
        {
            TrieNode node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new(c);
                }

                node = node.Children[c];
            }

            node.IsWordBoundary = true;
        }

        public bool Search(string word)
        {
            TrieNode node = _root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!node.Children.ContainsKey(word[i]))
                    return false;

                node = node.Children[word[i]];
            }

            return node.IsWordBoundary;
        }
    }
}