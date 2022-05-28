using System;

namespace BinaryTreeDistanceNodes
{
    internal class Solution
    {
        internal int Distance(TreeNode root, int n1, int n2)
        {
            int lca = int.MinValue;
            SearchLCA(root, n1, n2, ref lca);
            return DistanceFromRoot(root, n1, 0) + DistanceFromRoot(root, n2, 0) - (2 * DistanceFromRoot(root, lca, 0));
        }

        private bool SearchLCA(TreeNode? root, int n1, int n2, ref int lca)
        {
            if (root == null)
                return false;

            bool rootSearch = root.Data == n1 || root.Data == n2;
            bool leftSearch = SearchLCA(root.Left, n1, n2, ref lca);
            bool rightSearch = SearchLCA(root.Right, n1, n2, ref lca);

            if ((rootSearch && leftSearch) || (rootSearch && rightSearch) || (leftSearch && rightSearch))
            {
                lca = root.Data;
            }

            return rootSearch || leftSearch || rightSearch;
        }

        private int DistanceFromRoot(TreeNode? root, int target, int distance)
        {
            if (root == null)
                return int.MaxValue;

            if (root.Data == target)
                return distance;

            distance++;
            return Math.Min(DistanceFromRoot(root.Left, target, distance), DistanceFromRoot(root.Right, target, distance));
        }
    }
}