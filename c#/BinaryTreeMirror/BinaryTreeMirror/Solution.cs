using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeMirror
{
    internal class Solution
    {
        public TreeNode? MirrorTree(TreeNode? root)
        {
            Mirror(root);
            return root;
        }

        private void Mirror(TreeNode? root)
        {
            if (root != null)
            {
                TreeNode? temp = root.Left;
                root.Left = root.Right;
                root.Right = temp;

                Mirror(root.Left);
                Mirror(root.Right);
            }
        }
    }
}
