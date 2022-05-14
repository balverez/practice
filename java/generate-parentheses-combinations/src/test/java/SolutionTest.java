import org.junit.Test;
import java.util.HashSet;
import java.util.Set;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        Set<String> expected = new HashSet<>();
        expected.add("()");
        int test = 1;
        assertThat(expected.equals(new Solution().generateParentheses(test)));
    }

    @Test
    public void test2() {
        Set<String> expected = new HashSet<>();
        expected.add("()()");
        expected.add("(())");
        int test = 2;
        assertThat(expected.equals(new Solution().generateParentheses(test)));
    }
}
