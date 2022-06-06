namespace Subsets
{
    public class Solution
    {
        //O(n(2^n)) time
        //O(n) space
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> subsets = new();

            for (int k = 0; k <= nums.Length; k++)
                Backtrack(0, k, nums, new(), subsets);

            return subsets;
        }

        private void Backtrack(int start, int k, int[] nums, List<int> current, List<IList<int>> subsets)
        {
            if (current.Count >= k)
            {
                subsets.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                Backtrack(i + 1, k, nums, current, subsets);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}