using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeIterativeInOrderTraversal
{
    internal class Solution
    {
        public List<int> InOrder(TreeNode root)
        {
            List<int> result = new();

            if (root == null)
                return result;

            Stack<TreeNode> stack = new();
            TreeNode? iterator = root;

            while (iterator != null || stack.Count > 0)
            {
                while (iterator != null)
                {
                    stack.Push(iterator);
                    iterator = iterator.Left;
                }

                iterator = stack.Pop();
                result.Add(iterator.Data);
                iterator = iterator.Right;
            }

            return result;
        }
    }
}
