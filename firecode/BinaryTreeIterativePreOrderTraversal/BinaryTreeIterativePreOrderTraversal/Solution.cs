using System.Collections.Generic;

namespace BinaryTreeIterativePreOrderTraversal
{
    internal class Solution
    {
        internal List<int> PreOrder(TreeNode? root)
        {
            List<int> result = new();
            if (root == null)
                return result;

            Stack<TreeNode> stack = new();
            stack.Push(root);

            TreeNode node;
            while (stack.Count > 0)
            {
                node = stack.Pop();
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