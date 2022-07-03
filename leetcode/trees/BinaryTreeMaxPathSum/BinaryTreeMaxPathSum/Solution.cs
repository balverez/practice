namespace BinaryTreeMaxPathSum
{
    public class Solution
    {
        public int MaxPathSum(TreeNode root)
        {
            int max = int.MinValue;
            Recurse(root, ref max);

            return max;
        }

        private int Recurse(TreeNode? root, ref int max)
        {
            if (root == null)
                return 0;

            int leftMax = Math.Max(Recurse(root.left, ref max), 0);
            int rightMax = Math.Max(Recurse(root.right, ref max), 0);
            max = Math.Max(max, root.val + leftMax + rightMax);

            return root.val + Math.Max(leftMax, rightMax);
        }
    }
}