using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeMax
{
    internal class Solution
    {
        public int MaxData(TreeNode root)
        {
            if (root.Right == null)
                return root.Data;

            return MaxData(root.Right);
        }
    }
}
