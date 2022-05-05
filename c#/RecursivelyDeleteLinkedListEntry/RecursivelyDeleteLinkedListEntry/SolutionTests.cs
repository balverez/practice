using Xunit;

namespace RecursivelyDeleteLinkedListEntry
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            ListNode node1 = new ListNode(5);
            ListNode node2 = new ListNode(4, node1);
            ListNode middle = new ListNode(3, node2);
            ListNode node3 = new ListNode(2, middle);
            ListNode head = new ListNode(1, node3);

            int n = 3;

            int[] expectedData = { 1, 2, 3, 5 };
            ListNode? i = new Solution().DeleteAtIndex(head, n);
            int j = 0;
            int[] result = new int[4];
            while (i != null)
            {
                result[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expectedData, result);
        }

        [Fact]
        public void Test2()
        {
            int n = 1;

            Assert.Null(new Solution().DeleteAtIndex(null, n));
        }

        [Fact]
        public void Test3()
        {
            ListNode node2 = new ListNode(2);
            ListNode head = new ListNode(1, node2);

            int n = 3;

            int[] expectedData = { 1, 2 };
            ListNode? i = new Solution().DeleteAtIndex(head, n);
            int j = 0;
            int[] result = new int[2];
            while (i != null)
            {
                result[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expectedData, result);
        }
    }
}