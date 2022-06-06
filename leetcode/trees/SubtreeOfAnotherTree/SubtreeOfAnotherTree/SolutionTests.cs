namespace SubtreeOfAnotherTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            TreeNode root = new(3, new(4, new(1), new(2)), new(5));
            TreeNode subRoot = new(4, new(1), new(2));

            Assert.Equal(expected, new Solution().IsSubtree(root, subRoot));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            TreeNode root = new(3, new(4, new(1), new(2, new(0))), new(5));
            TreeNode subRoot = new(4, new(1), new(2));

            Assert.Equal(expected, new Solution().IsSubtree(root, subRoot));
        }
    }
}