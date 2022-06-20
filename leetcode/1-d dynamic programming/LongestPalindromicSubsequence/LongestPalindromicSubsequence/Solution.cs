namespace LongestPalindromicSubsequence
{
    public class Solution
    {
        //O(n^2) time
        //O(1) space
        public string LongestPalindrome(string s)
        {
            string longest = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                Search(s, i, i, ref longest);
                Search(s, i, i + 1, ref longest);
            }

            return longest;
        }

        private static void Search(string s, int left, int right, ref string longest)
        {
            while (left >= 0 && right < s.Length && s[left].Equals(s[right]))
            {
                left--;
                right++;
            }

            int length = right - left - 1;
            if (length > longest.Length)
                longest = s[(left + 1)..right];
        }
    }
}