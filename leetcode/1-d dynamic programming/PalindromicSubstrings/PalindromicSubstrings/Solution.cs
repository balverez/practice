namespace PalindromicSubstrings
{
    //O(n ^ 2) time
    //O(1) space
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                Search(s, i, i, ref count);
                Search(s, i, i + 1, ref count);
            }

            return count;
        }

        private void Search(string s, int l, int r, ref int count)
        {
            while (l >= 0 && r < s.Length && s[l].Equals(s[r]))
            {
                l--;
                r++;
                count++;
            }
        }
    }
}