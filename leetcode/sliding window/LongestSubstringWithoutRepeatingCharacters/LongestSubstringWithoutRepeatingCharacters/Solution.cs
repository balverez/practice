namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            Dictionary<char, int> charMap = new();

            int head;
            int tail = 0;
            for (head = 0; head < s.Length; head++)
            {
                char c = s[head];
                if (charMap.ContainsKey(c) && charMap[c] >= tail)
                    tail = charMap[c] + 1;

                maxLength = Math.Max(maxLength, head - tail + 1);
                charMap[c] = head;
            }

            return maxLength;
        }
    }
}