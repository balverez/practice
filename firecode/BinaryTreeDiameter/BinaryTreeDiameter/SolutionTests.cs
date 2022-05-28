using Xunit;

namespace BinaryTreeDiameter
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 4;
            TreeNode test = new(
                data: 1,
                left: new(2),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5)));

            Assert.Equal(expected, new Solution().TreeDiameter(test));
        }
    }
}