using Xunit;

namespace BinaryTreeMaxLevelSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            TreeNode test = new(
                data: 1,
                left: new(7),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5)));

            Assert.Equal(expected, new Solution().MaxLevelSum(test));
        }

        [Fact]
        public void Test2()
        {
            int expected = 2;
            TreeNode test = new(
                data: 1,
                left: new(2),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5)));

            Assert.Equal(expected, new Solution().MaxLevelSum(test));
        }
    }
}