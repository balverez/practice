namespace PalindromePartitioning
{
    public class Solution
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<string>> palindromes = new();
            Dictionary<string, bool> cache = new();
            Backtrack(palindromes, cache, new(), s, 0);

            return palindromes;
        }

        //O(n * 2^n) time
        //O(2^n) space
        private void Backtrack(List<IList<string>> palindromes, Dictionary<string, bool> cache, List<string> partitions, string s, int start)
        {
            if (start == s.Length)
            {
                palindromes.Add(new List<string>(partitions));
                return;
            }

            string candidate = string.Empty;
            for (int i = start; i < s.Length; i++)
            {
                candidate += s[i];
                if (IsPalindrome(cache, candidate))
                {
                    partitions.Add(candidate);
                    Backtrack(palindromes, cache, partitions, s, i + 1);
                    partitions.RemoveAt(partitions.Count - 1);
                }
            }
        }


        //O(k) time, where k is the length of the string.
        //O(1) space
        private bool IsPalindrome(Dictionary<string, bool> cache, string s)
        {
            if (cache.ContainsKey(s))
                return cache[s];

            if (s.Length == 1)
            {
                cache[s] = true;
                return cache[s];
            }

            cache[s] = VerifyPalindrome(s);
            return cache[s];
        }


        //O(k) time, where k is the length of the string.
        //O(1) space
        private bool VerifyPalindrome(string s)
        {
            int left;
            int right;
            if (s.Length % 2 == 0)
            {
                right = s.Length / 2;
                left = right - 1;
            }
            else
                right = left = s.Length / 2;

            while (left >= 0 && right < s.Length)
                if (s[left--] != s[right++])
                    return false;

            return true;
        }
    }
}