using Xunit;

namespace BinaryTreeSerDe
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 6;
            TreeNode test = new(6, new(4), null);

            Assert.Equal(expected, new Solution().SerDe(test)?.Data);
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            TreeNode test = new(1, new(2, null, new(4)), new(3, null, new(5)));

            Assert.Equal(expected, new Solution().SerDe(test)?.Right?.Data);
        }
    }
}