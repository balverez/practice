namespace MissingNumber
{
    internal class Solution
    {
        internal int MissingNumber(int[] nums)
        {
            int sum = ((nums.Length * nums.Length) + nums.Length) / 2;

            return sum - nums.Sum();
        }
    }
}