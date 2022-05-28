using Xunit;

namespace DeleteLinkedListEntry
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            ListNode node1 = new(5);
            ListNode node2 = new(4, node1);
            ListNode middle = new(3, node2);
            ListNode node3 = new ListNode(2, middle);
            ListNode head = new ListNode(1, node3);

            ListNode expectedNode1 = new(5);
            ListNode expectedNode2 = new(4, expectedNode1);
            ListNode expectedMiddle = new(3, expectedNode2);
            ListNode expectedNode3 = new ListNode(2, expectedMiddle);
            ListNode expectedHead = new ListNode(1, expectedNode3);

            int n = 5;

            int? expectedData = 0;
            ListNode? i = expectedHead;
            while (i != null)
            {
                n--;

                if (n == 0)
                {
                    expectedData = i.Next?.Data;
                    break;
                }

                i = i?.Next;
            }

            n = 5;
            i = new Solution().DeleteAtIndex(head, n);
            int? result = 0;
            while (i != null)
            {
                n--;

                if (n == 0)
                {
                    result = i.Next?.Data;
                    break;
                }

                i = i?.Next;
            }

            Assert.Equal(expectedData, result);
        }

        [Fact]
        public void Test2()
        {
            ListNode node1 = new(5);
            ListNode node2 = new(4, node1);
            ListNode middle = new(3, node2);
            ListNode node3 = new ListNode(2, middle);
            ListNode head = new ListNode(1, node3);

            int n = 3;
            int[] expectedData = { 1, 2, 3, 5};

            ListNode? i = new Solution().DeleteAtIndex(head, n);
            int j = 0;
            int[] result = new int[4];
            while (i != null)
            {
                result[j++] = i.Data;
                i = i?.Next;
            }

            Assert.Equal(expectedData, result);
        }

        [Fact]
        public void Test3()
        {
            ListNode node6 = new(6);
            ListNode node5 = new(5, node6);
            ListNode node4 = new(4, node5);
            ListNode node3 = new(3, node4);
            ListNode node2 = new(2, node3);
            ListNode head = new ListNode(1, node2);

            int n = 0;
            int[] expectedData = { 2, 3, 4, 5, 6 };

            ListNode? i = new Solution().DeleteAtIndex(head, n);
            int j = 0;
            int[] result = new int[5];
            while (i != null)
            {
                result[j++] = i.Data;
                i = i?.Next;
            }

            Assert.Equal(expectedData, result);
        }
    }
}