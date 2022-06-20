namespace DesignAddAndSearchWordsDataStructure
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; } = new();
        public bool IsWordBoundary { get; set; } = false;
    }
}