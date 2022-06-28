namespace InterleavingString
{
    public class Solution
    {
        //O(mn) time, where m is the length of s1 and n is the length of s2.
        //O(mn) space, where m is the length of s1 and n is the length of s2.
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s3.Length != s1.Length + s2.Length)
                return false;

            int[,] memo = new int[s1.Length, s2.Length];

            for (int i = 0; i < s1.Length; i++)
                for (int j = 0; j < s2.Length; j++)
                    memo[i, j] = -1;

            return Recurse(s1, 0, s2, 0, s3, 0, memo);
        }

        public bool Recurse(string s1, int i, string s2, int j, string s3, int k, int[,] memo)
        {
            if (i == s1.Length)
                return s2[j..].Equals(s3[k..]);
            if (j == s2.Length)
                return s1[i..].Equals(s3[k..]);

            if (memo[i, j] >= 0)
                return memo[i, j] == 1;

            bool result = false;
            if ((s1[i] == s3[k] && Recurse(s1, i + 1, s2, j, s3, k + 1, memo)) || (s2[j] == s3[k] && Recurse(s1, i, s2, j + 1, s3, k + 1, memo)))
                result = true;

            memo[i, j] = result ? 1 : 0;
            return result;
        }
    }
}