using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAncestors
{
    internal class Solution
    {
        internal List<int> ListAncestors(TreeNode root, int n)
        {
            List<int> ancestors = new();
            AncestorDfs(root, ancestors, n);
            return ancestors;
        }

        private bool AncestorDfs(TreeNode? root, List<int> ancestors, int n)
        {
            if (root == null)
                return false;
            if (root.Data == n)
                return true;
            if (AncestorDfs(root.Left, ancestors, n) || AncestorDfs(root.Right, ancestors, n))
            {
                ancestors.Add(root.Data);
                return true;
            }

            return false;
        }
    }
}
