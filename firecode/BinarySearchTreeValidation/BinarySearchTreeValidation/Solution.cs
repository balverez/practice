using System.Collections.Generic;

namespace BinarySearchTreeValidation
{
    internal class Solution
    {
        internal bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            Queue<BSTNode> queue = new();
            queue.Enqueue(new(root, int.MinValue, int.MaxValue));

            BSTNode iterator;
            while (queue.Count > 0)
            {
                iterator = queue.Dequeue();

                if (!iterator.IsValid())
                    return false;

                if (iterator.Left != null)
                    queue.Enqueue(new(iterator.Left, iterator.Min, iterator.Data));

                if (iterator.Right != null)
                    queue.Enqueue(new(iterator.Right, iterator.Data, iterator.Max));
            }

            return true;
        }
    }
}