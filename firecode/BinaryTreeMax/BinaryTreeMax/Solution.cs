using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeMax
{
    internal class Solution
    {
        public int MaxData(TreeNode? root)
        {
            if (root == null)
            {
                return int.MinValue;
            }

            return Math.Max(root.Data, Math.Max(MaxData(root.Left), MaxData(root.Right)));
        }
    }
}
