import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int base = 2;
        int exponent = 3;
        int expectedResult = 8;
        assertThat(new Solution().simplePow(base, exponent) == expectedResult);
    }

    @Test
    public void test2() {
        int base = 3;
        int exponent = 3;
        int expectedResult = 27;
        assertThat(new Solution().simplePow(base, exponent) == expectedResult);
    }

    @Test
    public void test3() {
        int base = -3;
        int exponent = 3;
        int expectedResult = -27;
        assertThat(new Solution().simplePow(base, exponent) == expectedResult);
    }
}
