namespace ValidAnagram
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> charMap = new();

            foreach (char c in s)
                charMap[c] = charMap.GetValueOrDefault(c, 0) + 1;

            foreach (char c in t)
                charMap[c] = charMap.GetValueOrDefault(c, 0) - 1;

            return !charMap.Any(c => c.Value != 0);
        }
    }
}