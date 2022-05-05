using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDeepestNode
{
    internal class Solution
    {
        public int DeepestNode(TreeNode root)
        {
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            TreeNode node = root;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return node.Data;
        }
    }
}
