public class Solution {
    /**
     * Returns true if the input integer is a palindrome
     * with constant space complexity.
     *
     * @param input Input integer to be tested.
     * @return True if the input integer is a palindrome.
     */
    public Boolean isPalindrome(int input) {
        int palindromeTest = input;
        int reverse = 0;

        while (palindromeTest != 0)
        {
            reverse = (reverse * 10) + palindromeTest % 10;
            palindromeTest = palindromeTest / 10;
        }

        return reverse == input;
    }
}