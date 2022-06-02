namespace DiameterOfABinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            TreeNode root = new(1, new(2, new(4), new(5)), new(3));

            Assert.Equal(expected, new Solution().DiameterOfBinaryTree(root));
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            TreeNode root = new(1, new(2), null);

            Assert.Equal(expected, new Solution().DiameterOfBinaryTree(root));
        }
    }
}