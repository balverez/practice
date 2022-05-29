namespace InvertBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 4, 7, 2, 9, 6, 3, 1 };
            TreeNode root = new(4,
                new(2, new(1), new(3)),
                new(7, new(6), new(9)));
            List<int> result = TreeBfs(new Solution().InvertTree(root));

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 2, 3, 1 };
            TreeNode root = new(2, new(1), new(3));
            List<int> result = TreeBfs(new Solution().InvertTree(root));

            Assert.Equal(expected, result);
        }

        private List<int> TreeBfs(TreeNode root)
        {
            List<int> result = new();
            Queue<TreeNode> currentLevel = new();
            currentLevel.Enqueue(root);
            Queue<TreeNode> nextLevel = new();

            TreeNode iterator;
            while (currentLevel.Count > 0)
            {
                iterator = currentLevel.Dequeue();
                result.Add(iterator.val);

                if (iterator.left != null)
                    nextLevel.Enqueue(iterator.left);

                if (iterator.right != null)
                    nextLevel.Enqueue(iterator.right);

                if (currentLevel.Count == 0)
                {
                    currentLevel = new(nextLevel);
                    nextLevel = new();
                }
            }

            return result;
        }
    }
}