namespace MissingNumber
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MissingNumber(int[] nums)
        {
            int bitmask = nums.Length;
            for (int i = 0; i < nums.Length; i++)
                bitmask ^= i ^ nums[i];

            return bitmask;
        }
    }
}