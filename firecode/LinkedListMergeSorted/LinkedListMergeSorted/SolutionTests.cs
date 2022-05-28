using System.Collections.Generic;
using Xunit;

namespace LinkedListMergeSorted
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            ListNode expected = new(0, new(1, new(2, new(3, new(4, new(5, new(6, new(7, new(8, new(9, new(10)))))))))));
            List<List<int>> test = new()
            {
                { new() { 1, 4 } },
                { new() { 2, 5, 6, 7, 9 } },
                { new() { 0, 3, 8, 10 } }
            };

            ListNode? result = new Solution().MergeLists(test);

            List<int> expectedList = new();
            ListNode? iterator = expected;
            while (iterator != null)
            {
                expectedList.Add(iterator.Data);
                iterator = iterator.Next;
            }

            List<int> resultList = new();
            iterator = result;
            while (iterator != null)
            {
                resultList.Add(iterator.Data);
                iterator = iterator.Next;
            }

            Assert.Equal(expectedList, resultList);
        }
    }
}