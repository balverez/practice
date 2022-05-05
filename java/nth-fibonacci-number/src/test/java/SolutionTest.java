import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int test = 4;
        int expected = 3;
        assertThat(new Solution().betterFibonacci(test) == expected);
    }
}
