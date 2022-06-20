namespace CountGoodNodesInBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 4;
            TreeNode root = new(3, new(1, new(3)), new(4, new(1), new(5)));

            Assert.Equal(expected, new Solution().GoodNodes(root));
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            TreeNode root = new(3, new(3, new(4), new(2)));

            Assert.Equal(expected, new Solution().GoodNodes(root));
        }

        [Fact]
        public void Test3()
        {
            int expected = 1;
            TreeNode root = new(1);

            Assert.Equal(expected, new Solution().GoodNodes(root));
        }
    }
}