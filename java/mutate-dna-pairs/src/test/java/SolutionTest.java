import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void test1() {
        assertThat(new Solution().mutateDnaPairs("AA") == "AGA");
    }

    @Test
    public void test2() {
        assertThat(new Solution().mutateDnaPairs("TTTT") == "TGTGTGT");
    }

    @Test
    public void test3() {
        assertThat(new Solution().mutateDnaPairs("TATA") == "TATA");
    }
}
