using Xunit;

namespace BinaryTreeDeepestNode
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new(
                data: 1,
                left: new(2),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5)));

            int expectedResult = 5;

            Assert.Equal(expectedResult, new Solution().DeepestNode(testRoot));
        }

        [Fact]
        public void Test2()
        {
            TreeNode testRoot = new(
                data: 1,
                left: new(
                    data: 2,
                    left: new(
                        data: 2,
                        left: new(200),
                        right: null),
                    right: null),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5)));

            int expectedResult = 200;

            Assert.Equal(expectedResult, new Solution().DeepestNode(testRoot));
        }
    }
}