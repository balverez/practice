using System;
using System.Collections.Generic;

namespace MaxIterativeBinaryTree
{
    internal class Solution
    {
        public int Max(TreeNode root)
        {
            int max = int.MinValue;
            Queue<TreeNode?> queue = new Queue<TreeNode?>();
            queue.Enqueue(root);

            TreeNode? node;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node != null)
                {
                    max = Math.Max(node.Data, max);
                    queue.Enqueue(node.Left);
                    queue.Enqueue(node.Right);
                }
            }

            return max;
        }
    }
}
