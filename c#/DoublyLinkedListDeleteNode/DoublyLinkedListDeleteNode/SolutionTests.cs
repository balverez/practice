using Xunit;

namespace DoublyLinkedListDeleteNode
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            DoublyLinkedListNode testHead = new DoublyLinkedListNode(1);
            testHead.Next = new DoublyLinkedListNode(2, testHead, null);
            testHead.Next.Next = new DoublyLinkedListNode(3, testHead.Next, null);
            testHead.Next.Next.Next = new DoublyLinkedListNode(4, testHead.Next.Next, null);
            testHead.Next.Next.Next.Next = new DoublyLinkedListNode(5, testHead.Next.Next.Next, null);
            int test = 3;

            DoublyLinkedListNode expectedHead = new DoublyLinkedListNode(1);
            expectedHead.Next = new DoublyLinkedListNode(2, expectedHead, null);
            expectedHead.Next.Next = new DoublyLinkedListNode(3, expectedHead.Next, null);
            expectedHead.Next.Next.Next = new DoublyLinkedListNode(5, expectedHead.Next.Next, null);


            Assert.Equal(expectedHead.Next.Next.Next.Data,
                new Solution().Delete(testHead, test)?.Next?.Next?.Next?.Data);
        }
    }
}