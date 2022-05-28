using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeNodeDistance
{
    internal class Solution
    {
        internal int NodeDistance(TreeNode root, int target) => DistanceDfs(root, target, 1);

        private int DistanceDfs(TreeNode? root, int target, int distance)
        {
            if (root == null)
                return int.MaxValue;

            if (root.Data == target)
                return distance;

            distance++;
            return Math.Min(
                DistanceDfs(root.Left, target, distance),
                DistanceDfs(root.Right, target, distance));
        }
    }
}
