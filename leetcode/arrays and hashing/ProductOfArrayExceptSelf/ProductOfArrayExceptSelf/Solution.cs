namespace ProductOfArrayExceptSelf
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = postfix * result[i];
                postfix *= nums[i];
            }

            return result;
        }
    }
}