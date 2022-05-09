using Xunit;

namespace BinarySearchTreeInsert
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new(
                data: 4,
                left: new(2),
                right: new(
                    data: 8,
                    left: new(5),
                    right: new(10))
                );

            int expectedData = 6;

            Assert.Equal(expectedData, new Solution().Insert(testRoot, expectedData)?.Right?.Left?.Right?.Data);
        }
    }
}