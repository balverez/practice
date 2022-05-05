using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreorderIterativeTraversal
{
    internal class Solution
    {
        public List<int> PreOrder(TreeNode root)
        {
            List<int> result = new();

            if (root == null)
                return result;


            Stack<TreeNode> stack = new();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();

                result.Add(node.Data);
                if (node.Right != null)
                    stack.Push(node.Right);
                if (node.Left != null)
                    stack.Push(node.Left);
            }

            return result;
        }
    }
}
