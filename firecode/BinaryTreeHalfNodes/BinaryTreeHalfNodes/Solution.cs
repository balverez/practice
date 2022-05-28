namespace BinaryTreeHalfNodes
{
    internal class Solution
    {
        internal int CountHalfNodes(TreeNode? root)
        {
            if (root == null)
                return 0;

            return (root.Left != null ^ root.Right != null ? 1 : 0) + CountHalfNodes(root.Left) + CountHalfNodes(root.Right);
        }
    }
}