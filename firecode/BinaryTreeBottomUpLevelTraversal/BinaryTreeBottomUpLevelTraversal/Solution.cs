using System.Collections.Generic;

namespace BinaryTreeBottomUpLevelTraversal
{
    internal class Solution
    {
        //O(n) time
        //O(n) space
        internal List<int> BottomUpLevelOrder(TreeNode root)
        {
            List<int> result = new();
            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);

            Queue<TreeNode> nextLevel = new();
            Stack<int> stack = new();

            TreeNode iterator;
            while (currentLevel.Count > 0)
            {
                iterator = currentLevel.Dequeue();
                stack.Push(iterator.Data);

                if (iterator.Right != null)
                    nextLevel.Enqueue(iterator.Right);

                if (iterator.Left != null)
                    nextLevel.Enqueue(iterator.Left);

                if (currentLevel.Count == 0)
                {
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            while (stack.Count > 0)
                result.Add(stack.Pop());

            return result;
        }
    }
}