namespace BalancedBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            TreeNode root = new(3, new(9), new(20, new(15), new(7)));

            Assert.Equal(expected, new Solution().IsBalanced(root));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            TreeNode root = new(1, new(2, new(3, new(4), new(4)), new(3)), new(2));

            Assert.Equal(expected, new Solution().IsBalanced(root));
        }

        [Fact]
        public void Test3()
        {
            bool expected = true;
            TreeNode? root = null;

            Assert.Equal(expected, new Solution().IsBalanced(root));
        }
    }
}