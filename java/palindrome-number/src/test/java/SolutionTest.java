import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int test = 1221;
        boolean expectedResult = true;
        assertThat(new Solution().isPalindrome(test) == expectedResult);
    }

    @Test
    public void test2() {
        int test = 121;
        boolean expectedResult = true;
        assertThat(new Solution().isPalindrome(test) == expectedResult);
    }

    @Test
    public void test3() {
        int test = 12;
        boolean expectedResult = false;
        assertThat(new Solution().isPalindrome(test) == expectedResult);
    }

    @Test
    public void test4() {
        int test = 0;
        boolean expectedResult = true;
        assertThat(new Solution().isPalindrome(test) == expectedResult);
    }
}
