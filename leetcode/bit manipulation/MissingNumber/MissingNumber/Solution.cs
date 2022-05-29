namespace MissingNumber
{
    internal class Solution
    {
        //O(n) time
        //O(1) space
        internal int MissingNumber(int[] nums)
        {
            int sum = (nums.Length * (nums.Length + 1)) / 2;

            return sum - nums.Sum();
        }
    }
}