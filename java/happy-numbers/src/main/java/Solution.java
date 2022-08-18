import java.util.HashSet;
import java.util.Set;

public class Solution {
    /**
     * Returns true if the input number is happy.
     *
     * @param n Integer to test.
     * @return True if the input integer is happy.
     */
    public Boolean isHappy(int n) {
        Set<Integer> observed = new HashSet<>();

        while (n != 1 && !observed.contains(n)) {
            observed.add(n);
            n = step(n);
        }

        return n == 1;
    }

    private int step(int n) {
        int happySum = 0;

        int remainder;
        while (n > 0) {
            remainder = n % 10;
            happySum += Math.pow(remainder, 2);
            n = n / 10;
        }

        return happySum;
    }
}