namespace TrieWordInsert
{
    internal class Trie
    {
        private TrieNode _root = new TrieNode(null);

        public void Insert(string word)
        {
            TrieNode node = _root;

            for (int i = 0; i < word.Length; i++)
            {
                if (node.Children.ContainsKey(word[i]))
                    node = node.Children[word[i]];
                else
                {
                    node.Children[word[i]] = new(word[i]);
                    node = node.Children[word[i]];
                }
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