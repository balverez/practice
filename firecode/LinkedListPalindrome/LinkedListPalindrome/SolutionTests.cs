using Xunit;

namespace LinkedListPalindrome
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, new int[] {1, 2, 2, 1})]
        [InlineData(true, new int[] {1, 2, 1})]
        [InlineData(false, new int[] {1, 2})]
        [InlineData(true, new int[] {0})]
        [InlineData(true, new int[] {})]
        public void Test(bool expected, int[] test)
        {
            ListNode? testHead = null;
            ListNode node = new(int.MinValue);
            foreach (int i in test)
            {
                if (testHead == null)
                {
                    testHead = new ListNode(i);
                    node = testHead;
                }
                else
                {
                    node.Next = new(i);
                    node = node.Next;
                }
            }

            Assert.Equal(expected, new Solution().IsPalindrome(testHead));
        }
    }
}