namespace SumOfSubarrayRanges
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public long SubArrayRanges(int[] nums)
        {
            long sum = 0;
            Stack<int> maxStack = new();
            Stack<int> minStack = new();
            for (int i = 0; i <= nums.Length; i++)
            {
                while (maxStack.Count > 0 && nums[maxStack.Peek()] < (i == nums.Length ? int.MaxValue : nums[i]))
                {
                    int j = maxStack.Pop();
                    int k = maxStack.Count > 0 ? maxStack.Peek() : -1;
                    sum += (long)nums[j] * (i - j) * (j - k);
                }

                while (minStack.Count > 0 && nums[minStack.Peek()] > (i == nums.Length ? int.MinValue : nums[i]))
                {
                    int j = minStack.Pop();
                    int k = minStack.Count > 0 ? minStack.Peek() : -1;
                    sum -= (long)nums[j] * (i - j) * (j - k);
                }

                maxStack.Push(i);
                minStack.Push(i);
            }

            return sum;
        }
    }
}