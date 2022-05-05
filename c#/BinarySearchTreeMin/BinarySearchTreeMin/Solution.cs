using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeMin
{
    internal class Solution
    {
        public int MinData(TreeNode root)
        {
            if (root.Left == null)
                return root.Data;

            return MinData(root.Left);
        }
    }
}
