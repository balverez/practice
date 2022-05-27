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

            int maxSum = int.MinValue;
            int maxLevel = int.MinValue;
            int sum = 0;
            int level = 0;
            TreeNode iterator;
            while (currentLevel.Count > 0)
            {
                iterator = currentLevel.Dequeue();
                sum += iterator.Data;

                if (iterator.Left != null)
                    nextLevel.Enqueue(iterator.Left);

                if (iterator.Right != null)
                    nextLevel.Enqueue(iterator.Right);

                if (currentLevel.Count == 0)
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxLevel = level;
                    }

                    level++;
                    sum = 0;
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            return maxLevel;
        }
    }
}