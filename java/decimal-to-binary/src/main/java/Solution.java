public class Solution {
    /**
     * Returns the minimal binary string representation of
     * the input decimal integer.
     *
     * @param decimal Positive decimal integer that's <= 1000.
     * @return String with binary representation of the input decimal.
     */
    public String toBinary(int decimal) {
        if (decimal <= 1) {
            return String.valueOf(decimal);
        }

        String bit = String.valueOf(decimal % 2);
        return toBinary(decimal / 2) + bit;
    }
}