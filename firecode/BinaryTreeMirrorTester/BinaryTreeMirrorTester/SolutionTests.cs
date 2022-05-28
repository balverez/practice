using Xunit;

namespace BinaryTreeMirrorTester
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            TreeNode testA = new(1, new(3, new(5), new(4)), new(2));
            TreeNode testB = new(1, new(2), new(3, new(4), new(5)));
            Assert.Equal(expected, new Solution().AreMirrored(testA, testB));
        }
    }
}