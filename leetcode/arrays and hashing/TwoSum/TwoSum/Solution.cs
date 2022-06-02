namespace TwoSum
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> differenceMap = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (differenceMap.ContainsKey(difference))
                    return new int[] { differenceMap[difference], i };

                differenceMap[nums[i]] = i;
            }

            return new int[] { };
        }
    }
}