using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeHalfNodes
{
    internal class Solution
    {
        public int CountHalf(TreeNode? root)
        {
            if (root == null)
                return 0;

            return ((root.Left != null ^ root.Right != null) ? 1 : 0) + CountHalf(root.Left) + CountHalf(root.Right);
        }
    }
}
