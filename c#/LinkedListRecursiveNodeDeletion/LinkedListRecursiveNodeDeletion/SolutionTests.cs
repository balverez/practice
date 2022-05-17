using Xunit;

namespace LinkedListRecursiveNodeDeletion
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));

            Assert.Equal(expected, new Solution().DeleteAtIndex(head, 1)?.Next?.Data);
        }
    }
}