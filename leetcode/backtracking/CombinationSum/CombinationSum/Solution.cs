namespace CombinationSum
{
    public class Solution
    {
        //O(n^(t/m)) time, where n is the number of candidates, t is the target value, and m is the minimal value among the candidates.
        //O(t/m) space, since recursive calls have to be made to enumerate the possible combinations.
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> result = new();
            Dfs(result, candidates, new(), 0, 0, target);
            return result;
        }

        private void Dfs(List<IList<int>> result, int[] candidates, List<int> current, int currentSum, int i, int target)
        {
            if (currentSum == target)
            {
                result.Add(new List<int>(current));
                return;
            }
            if (i >= candidates.Length || currentSum > target)
                return;

            for (int j = i; j < candidates.Length; j++)
            {
                current.Add(candidates[j]);
                currentSum += candidates[j];
                Dfs(result, candidates, current, currentSum, j, target);
                current.RemoveAt(current.Count - 1);
                currentSum -= candidates[j];
            }
        }
    }
}