using System.Collections.Generic;
using System.Linq;

namespace AnagramsSolution
{
    internal class Solution
    {
        public static bool isPairAnagram(string s1, string s2)
        {
            Dictionary<char, int> charMap = new();

            foreach (char c in s1.ToUpper())
                charMap[c] = charMap.GetValueOrDefault(c, 0) + 1;

            foreach (char c in s2.ToUpper())
                charMap[c] = charMap.GetValueOrDefault(c, 0) - 1;

            return charMap.All(entry => entry.Value == 0);
        }
    }
}
