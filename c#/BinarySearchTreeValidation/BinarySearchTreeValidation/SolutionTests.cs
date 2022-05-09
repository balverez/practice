using Xunit;

namespace BinarySearchTreeValidation
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            bool expected = true;

            TreeNode testRoot = new(
                data: 10,
                left: new(
                    data: 5,
                    left: new(4),
                    right: new(6)),
                right: new(
                    data: 15,
                    left: new(14),
                    right: new(16)));

            Assert.Equal(expected, new Solution().IsBST(testRoot));
        }
    }
}