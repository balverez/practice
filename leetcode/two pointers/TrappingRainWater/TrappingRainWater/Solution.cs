namespace TrappingRainWater
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int Trap(int[] height)
        {
            if (height.Length == 1)
                return 0;

            int l = 0;
            int r = height.Length - 1;
            while (l < height.Length && height[l] == 0)
                l++;
            while (r >= 0 && height[r] == 0)
                r--;

            int lm = 0;
            int rm = 0;
            int caught = 0;
            while (l < r)
            {
                if (height[l] > lm && height[r] > rm)
                    rm = lm = Math.Min(height[l], height[r]);

                if (height[l] < height[r])
                {
                    l++;
                    caught += height[l] < lm ? lm - height[l] : 0;
                }
                else
                {
                    r--;
                    caught += height[r] < rm ? rm - height[r] : 0;
                }
            }

            return caught;
        }
    }
}