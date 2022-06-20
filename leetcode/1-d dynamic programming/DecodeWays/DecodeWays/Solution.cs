namespace DecodeWays
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int NumDecodings(string s)
        {
            if (s[0] == '0')
                return 0;

            int oneBack = 1;
            int twoBack = 1;
            for (int i = 1; i < s.Length; i++)
            {
                int current = 0;

                if (s[i] != '0')
                    current = oneBack;

                if (s[i - 1] == '1' || (s[i - 1] == '2' && s[i] <= '6'))
                    current += twoBack;

                twoBack = oneBack;
                oneBack = current;
            }

            return oneBack;
        }
    }
}