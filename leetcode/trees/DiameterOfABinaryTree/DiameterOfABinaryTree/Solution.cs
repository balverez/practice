namespace DiameterOfABinaryTree
{
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode? root)
        {
            int maxDistance = 0;
            Recurse(root, ref maxDistance);
            return maxDistance;
        }

        private int Recurse(TreeNode? root, ref int maxDistance)
        {
            if (root == null)
                return 0;

            int leftDistance = Recurse(root.left, ref maxDistance);
            int rightDistance = Recurse(root.right, ref maxDistance);

            maxDistance = Math.Max(maxDistance, leftDistance + rightDistance);

            return Math.Max(1 + leftDistance, 1 + rightDistance);
        }
    }
}