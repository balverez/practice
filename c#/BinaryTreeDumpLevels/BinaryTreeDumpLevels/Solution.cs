using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDumpLevels
{
    internal class Solution
    {
        public List<List<int>> DumpTree(TreeNode root)
        {
            List<List<int>> result = new();
            
            if (root == null)
                return result;

            Queue<TreeNode> currentLevel = new();
            Queue<TreeNode> nextLevel = new();
            currentLevel.Enqueue(root);
            result.Add(new List<int>() { root.Data });

            TreeNode node;
            while (currentLevel.Count > 0)
            {
                node = currentLevel.Dequeue();

                if (node.Left != null)
                    nextLevel.Enqueue(node.Left);

                if (node.Right != null)
                    nextLevel.Enqueue(node.Right);

                if (currentLevel.Count == 0)
                {
                    if (nextLevel.Count > 0)
                    {
                        result.Add(nextLevel.Select(x => x.Data).ToList<int>());
                    }
                    currentLevel = nextLevel;
                    nextLevel = new();
                }
            }

            return result;
        }
    }
}
