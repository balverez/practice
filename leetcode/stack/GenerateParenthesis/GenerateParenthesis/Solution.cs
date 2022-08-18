namespace GenerateParenthesis
{
    public class Solution
    {
        //O(2^n) time
        //O(2^n) space
        public IList<string> GenerateParenthesis(int n)
        {
            Stack<char> stack = new();
            List<string> parenthesis = new();

            Backtrack(parenthesis, stack, n, n);

            return parenthesis;
        }

        private void Backtrack(List<string> parenthesis, Stack<char> stack, int open, int close)
        {
            if (open == 0 && close == 0)
            {
                parenthesis.Add(string.Join(string.Empty, stack));
                return;
            }

            if (open > 0)
            {
                stack.Push(')');
                Backtrack(parenthesis, stack, open - 1, close);
                stack.Pop();
            }

            if (close > open)
            {
                stack.Push('(');
                Backtrack(parenthesis, stack, open, close - 1);
                stack.Pop();
            }
        }
    }
}