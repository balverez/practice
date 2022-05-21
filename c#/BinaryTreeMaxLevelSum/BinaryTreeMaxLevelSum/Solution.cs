using System;
using System.Collections.Generic;

namespace BinaryTreeMaxLevelSum
{
    internal class Solution
    {

        //O(n) time
        //O(n) space
        public int MaxLevelSum(TreeNode root)
        {
            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);
            Queue<TreeNode> nextLevel = new();

            int level = 0;
            int levelSum = 0;
            int maxLevel = int.MinValue;
            int maxSum = int.MinValue;
            TreeNode node;
            while (currentLevel.Count > 0)
            {
                node = currentLevel.Dequeue();
                levelSum += node.Data;

                if (node.Left != null)
                    nextLevel.Enqueue(node.Left);

                if (node.Right != null)
                    nextLevel.Enqueue(node.Right);

                if (currentLevel.Count == 0)
                {
                    if (levelSum > maxSum)
                    {
                        maxSum = levelSum;
                        maxLevel = level;
                    }

                    level++;
                    levelSum = 0;
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            return maxLevel;
        }
    }
}