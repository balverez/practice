namespace KthSmallestElementBST
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            TreeNode root = new(3, new(1, null, new(2)), new(4));
            int k = 1;

            Assert.Equal(expected, new Solution().KthSmallest(root, k));
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            TreeNode root = new(5, new(3, new(2, new(1)), new(4)), new(6));
            int k = 3;

            Assert.Equal(expected, new Solution().KthSmallest(root, k));
        }
    }
}