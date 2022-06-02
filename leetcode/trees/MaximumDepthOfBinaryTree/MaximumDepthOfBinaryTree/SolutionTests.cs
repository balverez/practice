namespace MaximumDepthOfBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            TreeNode root = new(3, new(9), new(20, new(15), new(7)));

            Assert.Equal(expected, new Solution().MaxDepth(root));
        }

        [Fact]
        public void Test2()
        {
            int expected = 2;
            TreeNode root = new(1, null, new(2));

            Assert.Equal(expected, new Solution().MaxDepth(root));
        }
    }
}