using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeFullNodes
{
    internal class Solution
    {
        public int CountFull(TreeNode? root)
        {
            if (root == null)
                return 0;

            return ((root.Left != null && root.Right != null) ? 1 : 0) + CountFull(root.Left) + CountFull(root.Right);
        }
    }
}
