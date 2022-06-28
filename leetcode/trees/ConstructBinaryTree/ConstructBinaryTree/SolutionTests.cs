namespace ConstructBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] preorder = { 3, 9, 20, 15, 7 };
            int[] inorder = { 9, 3, 15, 20, 7 };

            TreeNode? root = new Solution().BuildTree(preorder, inorder);
            Assert.NotNull(root);
            if (root != null)
            {
                Assert.Equal(3, root.val);
                Assert.Equal(9, root?.left?.val);
                Assert.Null(root?.left?.left);
                Assert.Null(root?.left?.right);
                Assert.Equal(20, root?.right?.val);
                Assert.Equal(15, root?.right?.left?.val);
                Assert.Equal(7, root?.right?.right?.val);
            }
        }
    }
}