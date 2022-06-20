namespace SearchRotatedSortedArray
{
    public class Solution
    {
        //O(logn) time
        //O(1) space
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
                return nums[0] == target ? 0 : -1;

            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int p = (l + r) / 2;
                if (nums[p] == target)
                    return p;

                if (nums[p] >= nums[l])
                {
                    if (target >= nums[l] && target < nums[p])
                        r = p - 1;
                    else
                        l = p + 1;
                }
                else
                {
                    if (target <= nums[r] && target > nums[p])
                        l = p + 1;
                    else
                        r = p - 1;
                }
            }

            return -1;
        }
    }
}