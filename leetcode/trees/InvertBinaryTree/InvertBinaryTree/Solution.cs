namespace InvertBinaryTree
{
    //O(n) time
    //O(n) space
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            Recurse(root);
            return root;
        }

        private void Recurse(TreeNode? root)
        {
            if (root != null)
            {
                (root.right, root.left) = (root.left, root.right);
                Recurse(root.left);
                Recurse(root.right);
            }
        }
    }
}