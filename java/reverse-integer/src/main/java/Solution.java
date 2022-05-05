public class Solution {
    /**
     * Reverses the input integer with constant space complexity.
     *
     * @param input Input integer to be reversed.
     * @return Reversed integer.
     */
    public int reverse(int input) {
        int reverse = 0;
        int remainder = 0;

        while (input != 0) {
            remainder = input % 10;
            reverse = (reverse * 10) + remainder;
            input = input / 10;
        }

        return reverse;
    }
}