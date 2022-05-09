using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Solution
    {
        public bool isValid(string str)
        {
            Dictionary<char, char> parenthesesMap = new() { { '(', ')' }, { '{', '}' }, { '[', ']' } };
            Stack<char> stack = new();

            foreach (char c in str)
            {
                if (parenthesesMap.ContainsKey(c))
                    stack.Push(parenthesesMap[c]);
                else
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
