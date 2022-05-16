using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeKthLargest
{
    internal class Solution
    {
        internal int KthLargest(TreeNode root, int k)
        {
            List<int> data = new();
            BuildInOrder(root, data);
            return data[data.Count - k];
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
