using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeIdentical
{
    internal class Solution
    {
        internal bool AreIdentical(TreeNode? a, TreeNode? b)
        {
            if (a == null ^ b == null)
                return false;
            if (a == null)
                return true;
            
            return a.Data == b.Data && AreIdentical(a.Left, b.Left) && AreIdentical(a.Right, b.Right);
        }
    }
}
