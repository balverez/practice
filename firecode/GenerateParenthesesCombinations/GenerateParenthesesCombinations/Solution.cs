using System.Collections.Generic;

namespace GenerateParenthesesCombinations
{
    internal class Solution
    {
        //O(2^n) time
        //O(2^n) space
        public HashSet<string> GenerateParenthesis(int n)
        {
            HashSet<string> result = new();
            BuildRecursionTree(result, string.Empty, n, n);
            return result;
        }

        private void BuildRecursionTree(HashSet<string> result, string str, int open, int close)
        {
            if (open > 0)
                BuildRecursionTree(result, str + "(", (open - 1), close);
            if (close > open)
                BuildRecursionTree(result, str + ")", open, (close - 1));

            if (open == 0 && close == 0)
                result.Add(str);
        }
    }
}
