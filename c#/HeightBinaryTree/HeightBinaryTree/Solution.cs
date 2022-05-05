using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightBinaryTree
{
    internal class Solution
    {
        public int GetHeight(TreeNode? root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));
        }
    }
}
