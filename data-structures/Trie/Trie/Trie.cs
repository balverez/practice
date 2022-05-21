namespace Trie
{
    internal class Trie
    {
        private TrieNode _root = new(null);

        internal void Insert(string word)
        {
            TrieNode node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode(c);

                node = node.Children[c];
            }

            node.IsWordBoundary = true;
        }

        internal bool Search(string word)
        {
            TrieNode node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    return false;

                node = node.Children[c];
            }

            return node.IsWordBoundary;
        }
    }
}