namespace BinaryTreeMirrorTester
{
    internal class Solution
    {
        internal bool AreMirrored(TreeNode? treeA, TreeNode? treeB)
        {
            if (treeA != null ^ treeB != null)
                return false;
            if (treeA == null)
                return true;

            return treeA.Data == treeB.Data
                && AreMirrored(treeA.Left, treeB.Right)
                && AreMirrored(treeA.Right, treeB.Left);
        }
    }
}