using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeInsert
{
    internal class Solution
    {
        public TreeNode Insert(TreeNode? root, int n)
        {
            if (root == null)
                return new TreeNode(n);

            if (n < root.Data)
                root.Left = Insert(root.Left, n);
            else if (n > root.Data)
                root.Right = Insert(root.Right, n);

            return root;
        }
    }
}
