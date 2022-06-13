namespace BinaryTreeLevelOrderTraversal
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 3 },
                new List<int>() { 9, 20 },
                new List<int>() { 15, 7 }
            };

            TreeNode root = new(3, new(9), new(20, new(15), new(7)));

            Assert.Equal(expected, new Solution().LevelOrder(root));
        }

        [Fact]
        public void Test2()
        {
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1 }
            };

            TreeNode root = new(1);

            Assert.Equal(expected, new Solution().LevelOrder(root));
        }

        [Fact]
        public void Test3()
        {
            IList<IList<int>> expected = new List<IList<int>>();

            TreeNode? root = null;

            Assert.Equal(expected, new Solution().LevelOrder(root));
        }
    }
}