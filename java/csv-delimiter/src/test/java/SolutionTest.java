import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void charReplacement() {
        assertThat(new Solution().replaceCsvDelimiter(",1,2,3,4", "_") == "_1_2_3_4");
    }

    @Test
    public void singleChar() {
        assertThat(new Solution().replaceCsvDelimiter(",", "_") == "_");
    }

    @Test
    public void stringReplacement() {
        assertThat(new Solution().replaceCsvDelimiter(",1,2,3,4", "__") == "__1__2__3__4");
    }
}
