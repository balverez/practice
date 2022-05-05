using Xunit;

namespace ReverseLinkedList
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            ListNode testHead = new(1, new(2, new(3)));
            int[] expected = { 3, 2, 1 };

            ListNode? i = new Solution().Reverse(testHead);
            int j = 0;
            int[] resuultData = new int[3];

            while (i != null)
            {
                resuultData[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, resuultData);
        }
    }
}