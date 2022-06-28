namespace ContainerWithMostWater
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MaxArea(int[] height)
        {
            int max = int.MinValue;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                max = Math.Max(max, Math.Min(height[left], height[right]) * (right - left));

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return max;
        }
    }
}