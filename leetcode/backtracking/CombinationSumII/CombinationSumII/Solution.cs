namespace CombinationSumII
{
    public class Solution
    {
        //O(2^n) time
        //O(n) space
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> combinations = new();
            Array.Sort(candidates);
            Backtrack(candidates, combinations, new(), 0, target, 0);
            return combinations;
        }

        private void Backtrack(int[] nums, List<IList<int>> comb, List<int> cur, int sum, int target, int start)
        {
            if (sum == target)
            {
                comb.Add(new List<int>(cur));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                if (i != start && nums[i] == nums[i - 1])
                    continue;

                if (sum + nums[i] > target)
                    return;

                cur.Add(nums[i]);
                Backtrack(nums, comb, cur, sum + nums[i], target, i + 1);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}