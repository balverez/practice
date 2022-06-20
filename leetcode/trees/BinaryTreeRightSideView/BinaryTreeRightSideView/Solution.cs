namespace BinaryTreeRightSideView
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public IList<int> RightSideView(TreeNode? root)
        {
            List<int> result = new();
            if (root == null)
                return result;

            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);
            Queue<TreeNode> nextLevel = new();

            TreeNode node;
            while (currentLevel.Count > 0)
            {
                node = currentLevel.Dequeue();

                if (node.left != null)
                    nextLevel.Enqueue(node.left);
                if (node.right != null)
                    nextLevel.Enqueue(node.right);

                if (currentLevel.Count == 0)
                {
                    result.Add(node.val);
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            return result;
        }
    }
}