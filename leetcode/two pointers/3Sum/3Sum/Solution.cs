namespace _3Sum
{
    public class Solution
    {
        //O(n^2) time
        //O(1) space;
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            //O(nlogn) time
            Array.Sort(nums, Comparer<int>.Create((int x, int y) => x.CompareTo(y)));

            //O(n^2) time
            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
                if (i == 0 || nums[i] != nums[i - 1])
                    TwoSum(result, nums, i);

            return result;
        }

        //O(n) time
        //O(1) space
        private static void TwoSum(IList<IList<int>> result, int[] nums, int i)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    result.Add(new List<int>() { nums[i], nums[left++], nums[right--] });
                    while (left < right && nums[left] == nums[left - 1])
                        left++;
                }
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }
    }
}
