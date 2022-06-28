namespace ValidateBinarySearchTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            TreeNode root = new(2, new(1), new(3));

            Assert.Equal(expected, new Solution().IsValidBST(root));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            TreeNode root = new(5, new(1), new(4, new(3), new(6)));

            Assert.Equal(expected, new Solution().IsValidBST(root));
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            TreeNode root = new(3, new(1, new(0), new(2, null, new(3))), new(5, new(4), new(6)));

            Assert.Equal(expected, new Solution().IsValidBST(root));
        }

        [Fact]
        public void Test4()
        {
            bool expected = true;
            TreeNode root = new(-2147483648, null, new(2147483647));

            Assert.Equal(expected, new Solution().IsValidBST(root));
        }
    }
}