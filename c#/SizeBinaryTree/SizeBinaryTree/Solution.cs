using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeBinaryTree
{
    internal class Solution
    {
        public int Size(TreeNode? root)
        {
            return root == null
                ? 0
                : 1 + Size(root.Left) + Size(root.Right);
        }
    }
}
