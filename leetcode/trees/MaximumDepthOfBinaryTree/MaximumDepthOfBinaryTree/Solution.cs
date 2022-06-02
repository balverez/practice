namespace MaximumDepthOfBinaryTree
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int MaxDepth(TreeNode? root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);
            Queue<TreeNode> nextLevel = new();
            
            int depth = 1;
            TreeNode iterator;
            while (currentLevel.Count > 0)
            {
                iterator = currentLevel.Dequeue();

                if (iterator.left != null)
                    nextLevel.Enqueue(iterator.left);

                if (iterator.right != null)
                    nextLevel.Enqueue(iterator.right);

                if (currentLevel.Count == 0 && nextLevel.Count > 0)
                {
                    depth++;
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            return depth;
        }
    }
}