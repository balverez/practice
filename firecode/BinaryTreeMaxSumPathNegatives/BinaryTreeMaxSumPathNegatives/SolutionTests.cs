using Xunit;

namespace BinaryTreeMaxSumPathNegatives
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 120;
            TreeNode test = new(
                data: -100,
                left: new(90),
                right: new(
                    data: 90,
                    left: new(20),
                    right: new(10)));

            Assert.Equal(expected, new Solution().MaxSumPathWithNegatives(test));
        }

        [Fact]
        public void Test2()
        {
            int expected = 10;
            TreeNode test = new(
                data: 6,
                left: new(4),
                right: new(-8));

            Assert.Equal(expected, new Solution().MaxSumPathWithNegatives(test));
        }
    }
}