namespace LongestRepeatingCharacterReplacement
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int CharacterReplacement(string s, int k)
        {
            int longest = 0;
            Dictionary<char, int> charMap = new();
            int start = 0;
            int length = 0;
            foreach (char c in s)
            {
                length++;
                charMap[c] = charMap.GetValueOrDefault(c, 0) + 1;
                if (length - GetMaxCount(charMap) > k)
                {
                    charMap[s[start++]]--;
                    length--;
                }

                longest = Math.Max(longest, length);
            }

            return longest;
        }

        private static int GetMaxCount(Dictionary<char, int> charMap) => charMap.Max(map => map.Value);
    }
}