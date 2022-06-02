namespace BinarySearch
{
    public class Solution
    {
        //O(logn) time
        //O(1) space
        public int Search(int[] nums, int target)
        {
            int i;
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                i = left + ((right - left) / 2);
                if (nums[i] == target)
                    return i;

                if (target < nums[i])
                    right = i - 1;
                else
                    left = i + 1;
            }

            return -1;
        }
    }
}