import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int test = 2;
        boolean expected = true;
        assertThat(new Solution().isPowerOfTwo(test) == expected);
    }

    @Test
    public void test2() {
        int test = 3;
        boolean expected = false;
        assertThat(new Solution().isPowerOfTwo(test) == expected);
    }
}
