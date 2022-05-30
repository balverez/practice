namespace Subsets
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> subsets = new();
            int n = nums.Length;

            for (int k = 0; k < n + 1; k++)
                Backtrack(0, n, k, nums, new(), subsets);

            return subsets;
        }

        //O(n(2^n)) time
        //O(n) space
        private void Backtrack(
            int first,
            int n,
            int k,
            int[] nums,
            List<int> current,
            List<IList<int>> subsets)
        {
            if (current.Count == k)
            {
                subsets.Add(new List<int>(current));
                return;
            }

            for (int i = first; i < n; i++)
            {
                current.Add(nums[i]);
                Backtrack(i + 1, n, k, nums, current, subsets);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}