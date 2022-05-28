namespace BinaryTreeMaxSumPathNegatives
{
    internal class TreeNode
    {
        internal int Data { get; set; }
        internal TreeNode? Left { get; set; }
        internal TreeNode? Right { get; set; }

        internal TreeNode(int data, TreeNode? left, TreeNode? right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        internal TreeNode(int data) => Data = data;
    }
}