using System;

namespace BinaryTreeDiameter
{
    internal class Solution
    {
        public int TreeDiameter(TreeNode? root)
        {
            int longestPath = 0;
            if (root == null)
                return longestPath;

            BuildDiameterPath(root, ref longestPath);
            return longestPath;
        }

        //O(n) time
        //O(n) space
        private int BuildDiameterPath(TreeNode? root, ref int longestPath)
        {
            if (root == null)
                return 0;

            int leftPath = BuildDiameterPath(root.Left, ref longestPath);
            int rightPath = BuildDiameterPath(root.Right, ref longestPath);

            longestPath = Math.Max(longestPath, 1 + leftPath + rightPath);

            return 1 + Math.Max(leftPath, rightPath);
        }
    }
}