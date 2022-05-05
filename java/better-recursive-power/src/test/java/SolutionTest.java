import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int base = 2;
        int exponent = 3;
        int expectedResult = 8;
        assertThat(new Solution().betterPow(base, exponent) == expectedResult);
    }

    @Test
    public void test2() {
        int base = 3;
        int exponent = -1;
        double expectedResult = Math.pow(base, exponent);
        assertThat(new Solution().betterPow(base, exponent) == expectedResult);
    }

    @Test
    public void test3() {
        int base = -3;
        int exponent = 3;
        int expectedResult = -27;
        assertThat(new Solution().betterPow(base, exponent) == expectedResult);
    }

    @Test
    public void test4() {
        int base = 2;
        int exponent = 4;
        int expectedResult = 16;
        assertThat(new Solution().betterPow(base, exponent) == expectedResult);
    }

    @Test
    public void test5() {
        int base = 2;
        int exponent = -4;
        double expectedResult = Math.pow(base, exponent);
        assertThat(new Solution().betterPow(base, exponent) == expectedResult);
    }
}
