using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAncestors
{
    internal class Solution
    {
        internal List<int> ListAncestors(TreeNode root, int target)
        {
            List<int> ancestors = new();
            RetrieveAncestors(root, ancestors, target);
            return ancestors;
        }

        private bool RetrieveAncestors(TreeNode? root, List<int> ancestors, int target)
        {
            if (root == null)
                return false;
            else if (root.Data == target)
                return true;
            else if (RetrieveAncestors(root.Left, ancestors, target) || RetrieveAncestors(root.Right, ancestors, target))
            {
                ancestors.Add(root.Data);
                return true;
            }

            return false;
        }
    }
}
