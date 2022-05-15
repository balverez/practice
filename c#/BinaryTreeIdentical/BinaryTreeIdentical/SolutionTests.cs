using Xunit;

namespace BinaryTreeIdentical
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            TreeNode a = new(1, new(2), new(3));
            TreeNode b = new(1, new(2), new(3));
            Assert.Equal(expected, new Solution().AreIdentical(a, b));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            TreeNode a = new(1);
            a.Left = new(2);
            TreeNode b = new(2);
            b.Left = new(1);
            Assert.Equal(expected, new Solution().AreIdentical(a, b));
        }
    }
}