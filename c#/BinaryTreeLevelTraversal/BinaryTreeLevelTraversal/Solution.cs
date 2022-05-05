using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeLevelTraversal
{
    internal class Solution
    {
        public List<int> LevelOrder(TreeNode root)
        {
            List<int> result = new();

            if (root == null)
                return result;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            TreeNode node;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                result.Add(node.Data);

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return result;
        }
    }
}
