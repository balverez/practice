import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        assertThat(new Solution().checkValid("()[]()") == true);
    }

    @Test
    public void test2() {
        assertThat(new Solution().checkValid("(())") == true);
    }

    @Test
    public void test3() {
        assertThat(new Solution().checkValid("([)]") == false);
    }
}
