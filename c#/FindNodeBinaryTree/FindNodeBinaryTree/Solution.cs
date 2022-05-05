using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNodeBinaryTree
{
    internal class Solution
    {
        public bool FindNode(TreeNode root, int n)
        {
            if (root == null)
                return false;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node.Data == n)
                    return true;

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return false;
        }
    }
}
