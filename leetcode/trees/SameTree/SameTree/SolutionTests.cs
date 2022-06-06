namespace SameTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            TreeNode p = new(1, new(2), new(3));
            TreeNode q = new(1, new(2), new(3));

            Assert.Equal(expected, new Solution().IsSameTree(p, q));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            TreeNode p = new(1, new(2), null);
            TreeNode q = new(1, null, new(2));

            Assert.Equal(expected, new Solution().IsSameTree(p, q));
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            TreeNode p = new(1, new(2), new(1));
            TreeNode q = new(1, new(1), new(2));

            Assert.Equal(expected, new Solution().IsSameTree(p, q));
        }
    }
}