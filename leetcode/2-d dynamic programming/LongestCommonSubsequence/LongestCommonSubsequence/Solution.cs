namespace LongestCommonSubsequence
{
    public class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length + 1;
            int n = text2.Length + 1;

            int[,] lcs = new int[m, n];

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    if (text1[i - 1] == text2[j - 1])
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    else
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);

            return lcs[m - 1, n - 1];
        }
    }
}