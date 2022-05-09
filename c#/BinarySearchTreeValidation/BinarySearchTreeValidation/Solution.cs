using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeValidation
{
    internal class Solution
    {
        public bool IsBST(TreeNode root)
        {
            if (root == null)
                return true;

            EnrichedTreeNode node;
            Queue<EnrichedTreeNode> queue = new();
            queue.Enqueue(new EnrichedTreeNode(root, int.MinValue, int.MaxValue));

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (!node.IsValid())
                    return false;

                if (node.Left != null)
                    queue.Enqueue(new EnrichedTreeNode(node.Left, node.Min, node.Data));

                if (node.Right != null)
                    queue.Enqueue(new EnrichedTreeNode(node.Right, node.Data, node.Max));
            }

            return true;
        }
    }
}
