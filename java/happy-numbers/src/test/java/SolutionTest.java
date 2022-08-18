import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        assertThat(new Solution().isHappy(19)).isTrue();
    }

    @Test
    public void test2() {
        assertThat(new Solution().isHappy(4) == false);
    }
}
