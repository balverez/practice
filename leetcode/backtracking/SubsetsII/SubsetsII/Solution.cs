namespace SubsetsII
{
    //O(n * 2^n) time
    //O(n) space
    public class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> subsets = new();
            Array.Sort(nums);
            Backtrack(0, new List<int>(), nums, subsets);

            return subsets;
        }

        private void Backtrack(int start, List<int> current, int[] nums, List<IList<int>> subsets)
        {
            subsets.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                if (i != start && nums[i] == nums[i - 1])
                    continue;

                current.Add(nums[i]);
                Backtrack(i + 1, current, nums, subsets);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}