using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreOrderTraversal
{
    internal class Solution
    {
        public List<int> PreOrder(TreeNode root)
        {
            return BuildPreOrder(root, new List<int>());
        }

        private List<int> BuildPreOrder(TreeNode? root, List<int> result)
        {
            if (root != null)
            {
                result.Add(root.Data);
                result = BuildPreOrder(root.Left, result);
                result = BuildPreOrder(root.Right, result);
            }

            return result;
        }
    }
}
