namespace JumpGameII
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int Jump(int[] nums)
        {
            int jumps = 0;
            int currentJump = 0;
            int maxJump = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                maxJump = Math.Max(maxJump, i + nums[i]);

                if (i == currentJump)
                {
                    jumps++;
                    currentJump = maxJump;
                    if (currentJump >= nums.Length - 1)
                        return jumps;
                }
            }

            return jumps;
        }
    }
}