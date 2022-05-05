using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLeaves
{
    internal class Solution
    {
        public int CountLeaves(TreeNode? root)
        {
            if (root == null)
                return 0;

            if (root.Left == null && root.Right == null)
                return 1;

            return CountLeaves(root.Left) + CountLeaves(root.Right);
        }
    }
}
