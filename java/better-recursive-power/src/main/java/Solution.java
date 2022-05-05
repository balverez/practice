public class Solution {

    /**
     * Recursively raises base to exponent and returns
     * the result.
     *
     * @param base     The base.
     * @param exponent The power the base should be raised to.
     * @return Result of base ^ exponent.
     */
    public double betterPow(double base, int exponent) {        
        if (exponent == 0)
        {
            return 1L;
        }

        if (exponent % 2 == 0)
        {
            return exponent < 0 
                ? betterPow(1 / (base * base), -exponent / 2)
                : betterPow(base * base, exponent / 2);
        }
        else
        {
            return exponent < 0
                ? betterPow(1 / base, -exponent)
                : base * betterPow(base, exponent - 1);
        }
    }
}