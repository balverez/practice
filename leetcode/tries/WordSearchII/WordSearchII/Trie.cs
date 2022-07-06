namespace WordSearchII
{
    public class Trie
    {
        public TrieNode Root = new();

        public void Add(string s)
        {
            TrieNode node = Root;
            foreach (char c in s)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new();

                node = node.Children[c];
            }

            node.Word = s;
        }
    }
}