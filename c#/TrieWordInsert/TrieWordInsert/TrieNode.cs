using System.Collections.Generic;

namespace TrieWordInsert
{
    internal class TrieNode
    {
        internal char? Character { get; set; }
        internal bool IsWordBoundary { get; set; } = false;
        internal Dictionary<char, TrieNode> Children { get; set; } = new();
        
        internal TrieNode(char? character)
        {
            Character = character;
        }
    }
}