namespace HappyNumber
{
    public class Solution
    {
        //O(logn) time
        //O(1) space
        public bool IsHappy(int n)
        {
            int slow = n;
            int fast = Iteration(n);
            while (fast != 1 && slow != fast)
            {
                slow = Iteration(slow);
                fast = Iteration(Iteration(fast));
            }

            return fast == 1;
        }

        private int Iteration(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += (digit * digit);
                n /= 10;
            }

            return sum;
        }
    }
}