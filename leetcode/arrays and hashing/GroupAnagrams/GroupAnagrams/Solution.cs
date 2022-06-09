using System.Text;

namespace GroupAnagrams
{
    public class Solution
    {
        //O(nk) time
        //O(nk) space
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> groups = new();

            Dictionary<string, List<string>> anagrams = new();
            int[] characterCounts = new int[26];
            foreach (string str in strs)
            {
                foreach (char c in str)
                    characterCounts[c - 'a']++;

                StringBuilder characters = new StringBuilder();
                for (int i = 0; i < characterCounts.Length; i++)
                    characters.Append($@"#{characterCounts[i]}");

                string key = characters.ToString();
                if (anagrams.ContainsKey(key))
                    anagrams[key].Add(str);
                else
                    anagrams[key] = new() { str };

                Array.Fill(characterCounts, 0);
            }

            foreach (List<string> group in anagrams.Values)
                groups.Add(group);

            return groups;
        }
    }
}