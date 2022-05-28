using Xunit;

namespace LinkedListReversal
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
            int[] resultData = new int[3];

            while (i != null)
            {
                resultData[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, resultData);
        }

        [Fact]
        public void RecursionTest()
        {
            ListNode testHead = new(1, new(2, new(3)));
            int[] expected = { 3, 2, 1 };

            ListNode? i = new Solution().RecursiveReversal(testHead, null);
            int j = 0;
            int[] resultData = new int[3];

            while (i != null)
            {
                resultData[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, resultData);
        }
    }
}