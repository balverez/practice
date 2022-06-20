namespace BinaryTreeRightSideView
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() {1, 3, 4 };
            TreeNode root = new(1, new(2, null, new(5)), new(3, null, new(4)));

            Assert.Equal(expected, new Solution().RightSideView(root));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 1, 3 };
            TreeNode root = new(1, null, new(3));

            Assert.Equal(expected, new Solution().RightSideView(root));
        }

        [Fact]
        public void Test3()
        {
            List<int> expected = new();
            TreeNode? root = null;

            Assert.Equal(expected, new Solution().RightSideView(root));
        }
    }
}