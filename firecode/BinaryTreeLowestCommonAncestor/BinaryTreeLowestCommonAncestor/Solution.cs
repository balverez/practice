namespace BinaryTreeLowestCommonAncestor
{
    internal class Solution
    {
        internal int LCA(TreeNode root, int n1, int n2)
        {
            int lca = int.MinValue;
            Search(root, n1, n2, ref lca);
            return lca;
        }

        private bool Search(TreeNode? root, int n1, int n2, ref int lca)
        {
            if (root == null)
                return false;

            bool rootSearch = root.Data == n1 || root.Data == n2;
            bool leftSearch = Search(root.Left, n1, n2, ref lca);
            bool rightSearch = Search(root.Right, n1, n2, ref lca);

            if ((rootSearch && leftSearch) || (rootSearch && rightSearch) || (leftSearch && rightSearch))
            {
                lca = root.Data;
                return true;
            }

            return rootSearch || leftSearch || rightSearch;
        }
    }
}