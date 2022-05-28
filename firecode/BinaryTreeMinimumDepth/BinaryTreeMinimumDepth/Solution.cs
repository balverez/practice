using System.Collections.Generic;

namespace BinaryTreeMinimumDepth
{
    internal class Solution
    {
        internal int MinimumDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int minimumDepth = 1;
            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);
            Queue<TreeNode> nextLevel = new();

            TreeNode iterator;
            while (currentLevel.Count > 0)
            {
                iterator = currentLevel.Dequeue();

                if (iterator.Left == null && iterator.Right == null)
                    return minimumDepth;

                if (iterator.Left != null)
                    nextLevel.Enqueue(iterator.Left);

                if (iterator.Right != null)
                    nextLevel.Enqueue(iterator.Right);

                if (currentLevel.Count == 0)
                {
                    minimumDepth++;
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            return minimumDepth;
        }
    }
}