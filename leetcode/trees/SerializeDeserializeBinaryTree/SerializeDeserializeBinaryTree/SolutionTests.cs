namespace SerializeDeserializeBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 2, 3, 4, 5 };
            TreeNode root = new(1, new(2), new(3, new(4), new(5)));
            Codec codec = new Codec();

            Assert.Equal(expected, TreeBfs(codec.deserialize(codec.serialize(root))));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new();
            TreeNode? root = null;
            Codec codec = new Codec();

            Assert.Equal(expected, TreeBfs(codec.deserialize(codec.serialize(root))));
        }

        [Fact]
        public void Test3()
        {
            List<int> expected = new() { 1, 2, 3, 6, 4, 5 };
            TreeNode root = new(1, new(2, new(6)), new(3, null, new(4, null, new(5))));
            Codec codec = new Codec();

            Assert.Equal(expected, TreeBfs(codec.deserialize(codec.serialize(root))));
        }

        private List<int> TreeBfs(TreeNode? root)
        {
            List<int> result = new();
            if (root == null)
                return result;

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