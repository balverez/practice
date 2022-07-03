namespace ValidParenthesisString
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public bool CheckValidString(string s)
        {
            int openMax = 0;
            int openMin = 0;
            foreach (char c in s)
            {
                openMin += c == '(' ? 1 : -1;
                openMax += c != ')' ? 1 : -1;
                if (openMax < 0)
                    return false;
                openMin = Math.Max(openMin, 0);
            }

            return openMin == 0;
        }
    }
}