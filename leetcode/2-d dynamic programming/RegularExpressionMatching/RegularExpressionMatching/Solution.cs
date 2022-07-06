namespace RegularExpressionMatching
{
    public class Solution
    { 
        //O(nk) time, where n is the length of s and k is the length of p.
        //O(nk) space, where n is the length of s and k is the length of p.
        public bool IsMatch(string s, string p)
        {
            int[,] memo = new int[s.Length + 1, p.Length + 1];
            for (int i = 0; i <= s.Length; i++)
                for (int j = 0; j <= p.Length; j++)
                    memo[i, j] = -1;

            return DFS(memo, s, p, 0, 0);
        }

        private bool DFS(int[,] memo, string s, string p, int i, int j)
        {
            if (i >= s.Length && j >= p.Length)
                return true;
            
            if (j >= p.Length)
                return false;

            if (memo[i, j] >= 0)
                return memo[i, j] == 1;

            bool result = false;
            bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j < p.Length - 1 && p[j + 1] == '*')
                result = DFS(memo, s, p, i, j + 2) || (match && DFS(memo, s, p, i + 1, j));
            else if (match)
                result = DFS(memo, s, p, i + 1, j + 1);

            memo[i, j] = result == true ? 1 : 0;
            return result;
        }
    }
}