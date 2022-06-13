namespace KokoEatingBananas
{
    public class Solution
    {
        //O(nlogm) time, where m is the max amount of bananas in a pile.
        //O(1) space
        public int MinEatingSpeed(int[] piles, int h)
        {
            int max = piles.Max();

            int min = max;
            int left = 1;
            int right = max;
            while (left <= right)
            {
                int k = (left + right) / 2;

                double hours = 0;
                foreach (int i in piles)
                    hours += (int)Math.Ceiling(((double) i) / k);

                if (hours <= h)
                {
                    min = Math.Min(min, k);
                    right = k - 1;
                }
                else
                    left = k + 1;
            }

            return min;
        }
    }
}