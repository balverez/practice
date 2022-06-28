namespace Pow
{
    public class Solution
    {
        //O(logn) time
        //O(1) space
        public double MyPow(double x, int n)
        {
            long N = n;

            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }

            double result = 1;
            double current = x;
            for (long i = N; i > 0; i /= 2)
            {
                if ((i % 2) == 1)
                    result *= current;

                current *= current;
            }

            return result;
        }
    }
}