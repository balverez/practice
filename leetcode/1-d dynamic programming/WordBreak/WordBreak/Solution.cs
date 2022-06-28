namespace WordBreak
{
    public class Solution
    {
        //O(n^3) time
        //O(n) space
        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> dict = new(wordDict);
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i <= s.Length; i++)
                for (int j = 0; j < i; j++)
                    if (dp[j] && dict.Contains(s[j..i]))
                    {
                        dp[i] = true;
                        break;
                    }

            return dp[s.Length];
        }
    }
}