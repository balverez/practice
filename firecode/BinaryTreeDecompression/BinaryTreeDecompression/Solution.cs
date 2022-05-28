using System.Collections.Generic;
using System.Linq;

namespace BinaryTreeDecompression
{
    internal class Solution
    {
        internal TreeNode? Decompress(string compressed)
        {
            List<TreeNode?> nodes = compressed
                .Split(',')
                .Select(s => s.Equals("*") ? null : new TreeNode(int.Parse(s)))
                .ToList();

            Queue<TreeNode> queue = new();
            
            #pragma warning disable CS8604 // Possible null reference argument.
            // We are guaranteed at least one defined node.
            queue.Enqueue(nodes[0]);
            #pragma warning restore CS8604 // Possible null reference argument.

            TreeNode node = new(int.MinValue);
            TreeNode? nextNode;
            int childrenAdded = 0;
            for (int i = 1; i < nodes.Count; i++)
            {
                nextNode = nodes[i];

                if (childrenAdded == 0)
                {
                    node = queue.Dequeue();
                    node.Left = nextNode;
                    childrenAdded++;
                }
                else
                {
                    node.Right = nextNode;
                    childrenAdded = 0;
                }

                if (nextNode != null)
                    queue.Enqueue(nextNode);
            }

            return nodes[0];
        }
    }
}