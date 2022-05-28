using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeKthSmallest
{
    internal class Solution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            List<int> data = new();
            BuildInOrder(root, data);
            return data[k - 1];
        }

        private void BuildInOrder(TreeNode? root, List<int> data)
        {
            if (root != null)
            {
                BuildInOrder(root.Left, data);
                data.Add(root.Data);
                BuildInOrder(root.Right, data);
            }
        }
    }
}
