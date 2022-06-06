namespace Permutations
{
    public class Solution
    {
        //O(n * n!) time
        //O(n * n!) space
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> permutations = new();

            if (nums.Length == 1)
            {
                permutations.Add(new List<int>() { nums[0] });
                return permutations;
            }

            List<int> candidates = new(nums);
            for (int i = 0; i < candidates.Count; i++)
            {
                int first = candidates[0];
                candidates.RemoveAt(0);
                IList<IList<int>> subPermutations = Permute(candidates.ToArray());
                foreach (List<int> permutation in subPermutations)
                {
                    permutation.Add(first);
                    permutations.Add(permutation);
                }

                candidates.Add(first);
            }

            return permutations;
        }
    }
}