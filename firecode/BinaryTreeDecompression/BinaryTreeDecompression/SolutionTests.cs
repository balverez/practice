using Xunit;

namespace BinaryTreeDecompression
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode expected = new(1, new(2), new TreeNode(3));
            string test = "1,2,3";

            TreeNode? result = new Solution().Decompress(test);
            Assert.Equal(expected.Data, result?.Data);
            Assert.Equal(expected.Left?.Data, result.Left?.Data);
            Assert.Equal(expected.Right?.Data, result.Right?.Data);
        }

        [Fact]
        public void Test2()
        {
            TreeNode expected = new(1, new(2, null, new(4)), new TreeNode(3, null, new(5)));
            string test = "1,2,3,*,4,*,5";

            TreeNode? result = new Solution().Decompress(test);
            Assert.Equal(expected.Data, result?.Data);
            Assert.Equal(expected.Left?.Data, result.Left?.Data);
            Assert.Equal(expected.Left?.Right?.Data, result.Left?.Right?.Data);
            Assert.Equal(expected.Right?.Right?.Data, result.Right?.Right?.Data);
        }
    }
}