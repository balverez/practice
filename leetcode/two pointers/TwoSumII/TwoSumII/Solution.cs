namespace TwoSumII
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int difference = numbers[left] + numbers[right];

                if (difference == target)
                    return new int[] { left + 1, right + 1 };

                if (difference > target)
                    right--;
                else
                    left++;
            }

            return Array.Empty<int>();
        }
    }
}