using System;

namespace BinaryTreeMaxSumPath
{
    internal class Solution
    {
        internal int MaxPathSum(TreeNode? root)
        {
            int maxSum = 0;
            BuildMaxPath(root, ref maxSum);
            return maxSum;
        }

        private int BuildMaxPath(TreeNode? root, ref int maxSum)
        {
            if (root == null)
                return 0;

            int leftMax = BuildMaxPath(root.Left, ref maxSum);
            int rightMax = BuildMaxPath(root.Right, ref maxSum);

            maxSum = Math.Max(maxSum, root.Data + leftMax + rightMax);

            return Math.Max(root.Data + leftMax, root.Data + rightMax);
        }
    }
}