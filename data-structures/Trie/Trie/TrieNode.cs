using System.Collections.Generic;

namespace Trie
{
    internal class TrieNode
    {
        internal char? Character { get; set; }
        internal Dictionary<char, TrieNode> Children { get; set; } = new();
        internal bool IsWordBoundary { get; set; }

        internal TrieNode(char? character) => Character = character;
    }
}