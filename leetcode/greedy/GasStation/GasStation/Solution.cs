namespace GasStation
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int start = 0;
            int runningTank = 0;
            int currentTank = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                if (currentTank < 0)
                {
                    currentTank = 0;
                    start = i;
                }

                int currentCost = gas[i] - cost[i];
                currentTank += currentCost;
                runningTank += currentCost;
            }

            return runningTank >= 0 ? start : -1;
        }
    }
}