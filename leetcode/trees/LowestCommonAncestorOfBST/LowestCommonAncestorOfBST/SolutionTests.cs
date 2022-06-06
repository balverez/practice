namespace LowestCommonAncestorOfBST
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode expected = new(6);
            TreeNode root = new(6,
                new(2, new(0), new(4, new(3), new(5))),
                new(8, new(7), new(9)));
            TreeNode p = new(2);
            TreeNode q = new(8);

            Assert.Equal(expected.val, new Solution().LowestCommonAncestor(root, p, q).val);
        }

        [Fact]
        public void Test2()
        {
            TreeNode expected = new(2);
            TreeNode root = new(6,
                new(2, new(0), new(4, new(3), new(5))),
                new(8, new(7), new(9)));
            TreeNode p = new(2);
            TreeNode q = new(4);

            Assert.Equal(expected.val, new Solution().LowestCommonAncestor(root, p, q).val);
        }

        [Fact]
        public void Test3()
        {
            TreeNode expected = new(2);
            TreeNode root = new(2, new(1));
            TreeNode p = new(2);
            TreeNode q = new(1);

            Assert.Equal(expected.val, new Solution().LowestCommonAncestor(root, p, q).val);
        }
    }
}