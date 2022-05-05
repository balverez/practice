using System.Collections.Generic;
using System.Linq;

namespace AnagramsSolution
{
    internal class Solution
    {
        public static bool isPairAnagram(string s1, string s2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            s1.ToUpper().ToList().ForEach(c => map[c] = map.GetValueOrDefault(c, 0) + 1);

            s2.ToUpper().ToList().ForEach(c => map[c] = map.GetValueOrDefault(c, 0) - 1);

            return !map.Any(key => key.Value != 0);
        }
    }
}
