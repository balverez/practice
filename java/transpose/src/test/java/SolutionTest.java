import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[][] test = new int[][] { { 255, 0 }, { 255, 255 } };
        int[][] expectedResult = new int[][] { { 255, 255 }, { 0, 255 } };
        assertThat(new Solution().transpose(test) == expectedResult);
    }
}
