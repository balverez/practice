namespace ImplementTrie
{
    public class TrieNode
    {
        public char? Character;
        public Dictionary<char, TrieNode> Children = new();
        public bool IsWordBoundary;

        public TrieNode(char? character = null)
        {
            Character = character;
        }
    }
}