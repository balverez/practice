using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeMinimumDepth
{
    internal class Solution
    {
        public int MinimumDepth(TreeNode? root)
        {
            if (root == null)
                return 0;

            TreeNode node;
            Queue<TreeNode> currentLevel = new();
            Queue<TreeNode> nextLevel = new();
            
            int minimumDepth = 1;
            currentLevel.Enqueue(root);

            while (currentLevel.Count > 0)
            {
                node = currentLevel.Dequeue();

                if (node.Left == null && node.Right == null)
                    return minimumDepth;

                if (node.Left != null)
                    nextLevel.Enqueue(node.Left);

                if (node.Right != null)
                    nextLevel.Enqueue(node.Right);

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
