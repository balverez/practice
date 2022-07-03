namespace BinaryTreeMaxPathSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 6;
            TreeNode root = new(1, new(2), new(3));

            Assert.Equal(expected, new Solution().MaxPathSum(root));
        }

        [Fact]
        public void Test2()
        {
            int expected = 42;
            TreeNode root = new(-10, new(9), new(20, new(15), new(7)));

            Assert.Equal(expected, new Solution().MaxPathSum(root));
        }

        [Fact]
        public void Test3()
        {
            int expected = 2;
            TreeNode root = new(2, new(-1));

            Assert.Equal(expected, new Solution().MaxPathSum(root));
        }

        [Fact]
        public void Test4()
        {
            int expected = 4;
            TreeNode root = new(1, new(-2), new(3));

            Assert.Equal(expected, new Solution().MaxPathSum(root));
        }
    }
}