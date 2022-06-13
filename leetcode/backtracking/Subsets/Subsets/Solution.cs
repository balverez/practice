namespace Subsets
{
    public class Solution
    {
        //O(n(2^n)) time
        //O(n) space
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            Backtrack(subsets, nums, new(), 0);

            return subsets;
        }

        private void Backtrack(IList<IList<int>> subsets, int[] nums, List<int> current, int start)
        {
            subsets.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                Backtrack(subsets, nums, current, i + 1);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}