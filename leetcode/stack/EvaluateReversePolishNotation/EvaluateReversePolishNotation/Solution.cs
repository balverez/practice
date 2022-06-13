namespace EvaluateReversePolishNotation
{
    public class Solution
    {
        public static Dictionary<string, Func<int, int, int>> OperatorMappings = new()
        {
            { "+", (int x, int y) => x + y },
            { "-", (int x, int y) => x - y },
            { "*", (int x, int y) => x * y },
            { "/", (int x, int y) => x / y }
        };

        //O(n) time
        //O(n) space
        public int EvalRPN(string[] tokens)
        {
            Stack<string> stack = new();
            foreach (string token in tokens)
                stack.Push(token);

            return Recurse(stack);
        }

        private int Recurse(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                if (OperatorMappings.ContainsKey(stack.Peek()))
                {
                    string action = stack.Pop();
                    int second = Recurse(stack);
                    int first = Recurse(stack);
                    return OperatorMappings[action].Invoke(first, second);
                }

                return int.Parse(stack.Pop());
            }

            return 0;
        }
    }
}