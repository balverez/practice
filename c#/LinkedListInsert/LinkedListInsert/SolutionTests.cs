using Xunit;

namespace LinkedListInsert
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            ListNode testHead = new(1, new(2, new(3)));
            int testData = -1;
            int testIndex = 0;
            int[] expected = { -1, 1, 2, 3 };

            ListNode? i = new Solution().Insert(testHead, testData, testIndex);
            int j = 0;
            int[] resuultData = new int[4];

            while (i != null)
            {
                resuultData[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, resuultData);
        }

        [Fact]
        public void Test2()
        {
            ListNode testHead = new(1, new(2, new(3)));
            int testData = -1;
            int testIndex = 5;
            int[] expected = { 1, 2, 3, -1 };

            ListNode? i = new Solution().Insert(testHead, testData, testIndex);
            int j = 0;
            int[] resuultData = new int[4];

            while (i != null)
            {
                resuultData[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, resuultData);
        }

        [Fact]
        public void Test3()
        {
            ListNode testHead = new(1, new(2, new(3)));
            int testData = -1;
            int testIndex = 2;
            int[] expected = { 1, 2, -1, 3 };

            ListNode? i = new Solution().Insert(testHead, testData, testIndex);
            int j = 0;
            int[] resuultData = new int[4];

            while (i != null)
            {
                resuultData[j++] = i.Data;
                i = i.Next;
            }

            Assert.Equal(expected, resuultData);
        }
    }
}