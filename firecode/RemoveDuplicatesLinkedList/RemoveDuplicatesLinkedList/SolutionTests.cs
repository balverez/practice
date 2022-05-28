using Xunit;

namespace RemoveDuplicatesLinkedList
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            ListNode testHead = new(1, new(2, new(3, new(1, new(2)))));
            int[] expected = {1, 2, 3};

            ListNode? head = new Solution().RemoveDuplicates(testHead);
            ListNode? i = head;
            int j = 0;
            int[] results = new int[3];
            while (i != null)
            {
                results[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, results);
        }
    }
}