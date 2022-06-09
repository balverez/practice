namespace CountingBits
{
    //O(n) time
    //O(1) space
    public class Solution
    {
        public int[] CountBits(int n)
        {
            int[] bits = new int[n + 1];
            for (int i = 1; i <= n; i++)
                bits[i] = bits[i & i - 1] + 1;

            return bits;
        }
    }
}