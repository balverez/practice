import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int test = 351;
        int expectedResult = 153;
        assertThat(new Solution().reverse(test) == expectedResult);
    }

    @Test
    public void test2() {
        int test = 123;
        int expectedResult = 321;
        assertThat(new Solution().reverse(test) == expectedResult);
    }

    @Test
    public void test3() {
        int test = 12;
        int expectedResult = 21;
        assertThat(new Solution().reverse(test) == expectedResult);
    }

    @Test
    public void test4() {
        int test = 0;
        int expectedResult = 0;
        assertThat(new Solution().reverse(test) == expectedResult);
    }
}
