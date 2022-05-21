import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        assertThat(new Solution().isPairAnagram("firecode", "CodEfire") == true);
    }
}
