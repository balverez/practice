using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeNodeDistance
{
    internal class Solution
    {
        internal int NodeDistance(TreeNode root, int target)
        {
            return RecursiveSearch(root, target, 1);
        }

        private int RecursiveSearch(TreeNode? root, int target, int distance)
        {
            if (root == null)
                return int.MaxValue;

            if (root.Data == target)
                return distance;
            else
                return Math.Min(RecursiveSearch(root.Left, target, distance + 1), RecursiveSearch(root.Right, target, distance + 1));
        }
    }
}
