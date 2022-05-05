public class Solution {

    /**
     * Recursively raises base to exponent and returns
     * the result.
     *
     * @param base     The base.
     * @param exponent The power the base should be raised to.
     * @return Result of base ^ exponent.
     */
    public long simplePow(int base, int exponent) {
        long pow = 1;
        
        if (exponent > 0)
        {
            pow = base * simplePow(base, --exponent);
        }

        return pow;
    }
}