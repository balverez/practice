namespace JumpGame
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public bool CanJump(int[] nums)
        {
            int n = nums.Length;

            int currentJump = 1;
            for (int i = 0; i < n; i++)
            {
                currentJump = Math.Max(--currentJump, nums[i]);
                if (i + currentJump >= n - 1)
                    return true;
                else if (currentJump <= 0)
                    return false;
            }

            return false;
        }
    }
}