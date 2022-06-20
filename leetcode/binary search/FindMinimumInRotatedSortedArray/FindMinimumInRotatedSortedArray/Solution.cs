namespace FindMinimumInRotatedSortedArray
{
    public class Solution
    {
        //O(logn) time
        //O(1) space
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int l = 0;
            int r = nums.Length - 1;

            if (nums[l] < nums[r])
                return nums[l];

            while (l < r)
            {
                int p = (l + r) / 2;

                if (nums[p] > nums[p + 1])
                    return nums[p + 1];

                if (nums[p] < nums[p - 1])
                    return nums[p];

                if (nums[p] > nums[r])
                    l = p + 1;
                else
                    r = p - 1;
            }

            return nums[0];
        }
    }
}