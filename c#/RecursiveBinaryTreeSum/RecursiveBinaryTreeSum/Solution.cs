using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSum
{
    internal class Solution
    {
        public int SumNodes(TreeNode? root)
        {
            if (root == null)
                return 0;

            return root.Data + SumNodes(root.Left) + SumNodes(root.Right);
        }
    }
}
