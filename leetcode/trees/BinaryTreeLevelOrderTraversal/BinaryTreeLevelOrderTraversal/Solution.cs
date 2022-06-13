namespace BinaryTreeLevelOrderTraversal
{
    //O(n) time
    //O(n) space
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode? root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);
            Queue<TreeNode> nextLevel = new();

            List<int> levelValues = new();
            TreeNode node;
            while (currentLevel.Count > 0)
            {
                node = currentLevel.Dequeue();
                levelValues.Add(node.val);

                if (node.left != null)
                    nextLevel.Enqueue(node.left);

                if (node.right != null)
                    nextLevel.Enqueue(node.right);

                if (currentLevel.Count == 0)
                {
                    result.Add(new List<int>(levelValues));
                    levelValues = new();

                    if (nextLevel.Count > 0)
                    {
                        currentLevel = new(nextLevel);
                        nextLevel = new();
                    }
                }
            }

            return result;
        }
    }
}