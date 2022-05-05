using Xunit;

namespace SinglyLinkedListInsertNode
{
    public class SolutionTests
    {
        [Fact]
        public void InsertTest()
        {
            ListNode head = new(1);
            head = Solution.InsertAtEnd(head, 2);
            head = Solution.InsertAtEnd(head, 3);

            Assert.Equal(2, head.Next?.Data);
            Assert.Equal(3, head.Next?.Next?.Data);
        }

        [Fact]
        public void NullTest()
        {
            ListNode head = Solution.InsertAtEnd(null, 1);
            Assert.NotNull(head);
        }
    }
}