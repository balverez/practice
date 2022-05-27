namespace BinarySearchTreeValidation
{
    internal class BSTNode : TreeNode
    {
        private int _min;
        private int _max;

        internal int Min => _min;
        internal int Max => _max;

        internal BSTNode(TreeNode root, int min, int max)
            : base(root.Data, root.Left, root.Right)
        {
            _min = min;
            _max = max;
        }

        internal bool IsValid()
        {
            return Data > _min && Data < _max;
        }
    }
}