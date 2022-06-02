namespace MinCostClimbingStairs
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            int oneStep = 0;
            int twoSteps = 0;

            for (int i = 2; i < n + 1; i++)
            {
                int temp = oneStep;
                oneStep = Math.Min(cost[i - 1] + oneStep, cost[i - 2] + twoSteps);
                twoSteps = temp;
            }

            return oneStep;
        }
    }
}