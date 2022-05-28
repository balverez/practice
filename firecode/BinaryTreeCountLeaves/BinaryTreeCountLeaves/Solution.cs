using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeCountLeaves
{
    internal class Solution
    {
        public int CountLeaves(TreeNode? root)
        {
            if (root == null)
                return 0;

            return (root.Left == null && root.Right == null ? 1 : 0) + CountLeaves(root.Left) + CountLeaves(root.Right);
        }
    }
}
