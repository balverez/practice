using System;

namespace BinaryTreeMaxSumPathNegatives
{
    internal class Solution
    {
        internal int MaxSumPathWithNegatives(TreeNode? root)
        {
            if (root == null)
                return 0;

            int maxSum = int.MinValue;
            BuildMaxSumPath(root, ref maxSum);

            return maxSum;
        }

        private int BuildMaxSumPath(TreeNode? root, ref int maxSum)
        {
            if (root == null)
                return 0;

            int leftMax = Math.Max(0, BuildMaxSumPath(root.Left, ref maxSum));
            int rightMax = Math.Max(0, BuildMaxSumPath(root.Right, ref maxSum));

            maxSum = Math.Max(maxSum, root.Data + leftMax + rightMax);

            return Math.Max(root.Data + leftMax, root.Data + rightMax);
        }
    }
}