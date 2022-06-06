namespace BalancedBinaryTree
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public bool IsBalanced(TreeNode? root)
        {
            bool isBalanced = true;
            if (root == null)
                return isBalanced;

            Recurse(root, 0, ref isBalanced);
            return isBalanced;
        }

        private int Recurse(TreeNode? root, int height, ref bool isBalanced)
        {
            if (root == null)
                return height;

            height++;
            int leftHeight = Recurse(root.left, height, ref isBalanced);
            int rightHeight = Recurse(root.right, height, ref isBalanced);

            if (Math.Abs(leftHeight - rightHeight) > 1)
                isBalanced = false;

            return Math.Max(leftHeight, rightHeight);
        }
    }
}