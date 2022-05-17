using Xunit;

namespace BinaryTreeMaxSumPath
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 18;
            TreeNode test = new(
                data: 1,
                left: new(
                    data: 2,
                    left: new(4),
                    right: new(5)),
                right: new(
                    data: 3,
                    left: new(6),
                    right: new(7)));

            Assert.Equal(expected, new Solution().MaxPathSum(test));
        }

        [Fact]
        public void Test2()
        {
            int expected = 40;

            TreeNode leftChild = new(3, null, new(5, null, new(8)));
            TreeNode rightChild = new(4, new(6, new(9), new(10)), new(7, null, new(11)));
            TreeNode rootChild = new(2, leftChild, rightChild);
            TreeNode test = new(1, rootChild, null);

            Assert.Equal(expected, new Solution().MaxPathSum(test));
        }
    }
}