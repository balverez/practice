import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int test = 1;
        String expectedResult = "1";
        assertThat(new Solution().toBinary(test) == expectedResult);
    }

    @Test
    public void test2() {
        int test = 3;
        String expectedResult = "11";
        assertThat(new Solution().toBinary(test) == expectedResult);
    }

    @Test
    public void test3() {
        int test = 5;
        String expectedResult = "101";
        assertThat(new Solution().toBinary(test) == expectedResult);
    }

    @Test
    public void test4() {
        int test = 7;
        String expectedResult = "111";
        assertThat(new Solution().toBinary(test) == expectedResult);
    }

    @Test
    public void test5() {
        int test = 10;
        String expectedResult = "1010";
        assertThat(new Solution().toBinary(test) == expectedResult);
    }
}
