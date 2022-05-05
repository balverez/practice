import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        assertThat(new Solution().countPaths(2, 2) == 2);
    }

    @Test
    public void test2() {
        assertThat(new Solution().countPaths(3, 5) == 15);
    }
}
