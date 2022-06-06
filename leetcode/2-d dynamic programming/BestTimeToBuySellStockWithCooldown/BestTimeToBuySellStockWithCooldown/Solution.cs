namespace BestTimeToBuySellStockWithCooldown
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MaxProfit(int[] prices)
        {
            int cooldown = 0;
            int held = int.MinValue;
            int sold = int.MinValue;

            int presale;
            foreach(int price in prices)
            {
                presale = sold;
                sold = held + price;
                held = Math.Max(held, cooldown - price);
                cooldown = Math.Max(cooldown, presale);
            }

            return Math.Max(sold, cooldown);
        }
    }
}