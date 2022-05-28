using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeRangeList
{
    internal class Solution
    {
        internal List<int> ListInRange(TreeNode root, int a, int b)
        {
            List<int> data = new();
            RetrieveData(root, data, a, b);
            return data;
        }

        private void RetrieveData(TreeNode? root, List<int> data, int a, int b)
        {
            if (root != null)
            {
                if (root.Data > a)
                    RetrieveData(root.Left, data, a, b);

                if (root.Data >= a && root.Data <= b)
                    data.Add(root.Data);

                if (root.Data < b)
                    RetrieveData(root.Right, data, a, b);
            }
        }
    }
}
