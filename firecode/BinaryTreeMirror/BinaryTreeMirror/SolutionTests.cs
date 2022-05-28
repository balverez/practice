using Xunit;

namespace BinaryTreeMirror
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode expected = new(1, new(3, new(5), new(4)), new(2));
            TreeNode test = new(1, new(2), new(3, new(4), new(5)));
            Assert.Equal(expected.Left?.Left?.Data, new Solution().MirrorTree(test)?.Left?.Left?.Data);
        }
    }
}