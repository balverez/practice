public class Solution {
    /**
     * Returns the nth Fibonacci number in linear time and
     * with constant space.
     *
     * @param n Which number to return in the sequence.
     * @return Nth Fibonacci number.
     */
    public long betterFibonacci(int n) {
        if (n == 0)
        {
            return 0;
        }

        if (n < 3)
        {
            return 1;
        }

        long nMinus1 = 1;
        long nMinus2 = 1;
        long result = 0;

        for (int i = 3; i <= n; i++) {
            result = nMinus1 + nMinus2;
            nMinus2 = nMinus1;
            nMinus1 = result;
        }

        return result;
    }
}