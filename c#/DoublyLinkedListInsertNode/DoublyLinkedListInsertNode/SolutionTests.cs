using Xunit;

namespace DoublyLinkedListInsertNode
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            DoublyLinkedListNode head = new DoublyLinkedListNode(1);
            head.Next = new DoublyLinkedListNode(2, head, null);
            head.Next.Next = new DoublyLinkedListNode(3, head.Next, null);
            int test = -1;

            Assert.Equal(test, new Solution().Insert(head, test, 0)?.Data);
        }
    }
}