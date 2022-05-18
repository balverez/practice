namespace BinaryTreeRecursivePreOrderTraversal
{
    internal class TreeNode
    {
        internal int Data { get; set; }
        internal TreeNode? Left { get; set; } = null;
        internal TreeNode? Right { get; set; } = null;

        internal TreeNode(int data, TreeNode? left, TreeNode? right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        internal TreeNode(int data) => Data = data;
    }
}