namespace WordSearchII
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; } = new();
        public string? Word { get; set; } = null;
    }
}