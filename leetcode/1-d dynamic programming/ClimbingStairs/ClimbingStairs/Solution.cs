namespace ClimbingStairs
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;

            int oneStepBack = 2;
            int twoStepsBack = 1;

            for (int i = 3; i < n + 1; i++)
            {
                int temp = oneStepBack;
                oneStepBack +=  twoStepsBack;
                twoStepsBack = temp;
            }

            return oneStepBack;
        }
    }
}