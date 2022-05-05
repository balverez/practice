import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[][] test = new int[][] { {255, 0, 0}, {0, 0, 255} };
        int[][] expectedResult = new int[][] { {0, 0, 255}, {255, 0, 0} };
        assertThat(new Solution().flipImage(test) == expectedResult);
    }

    @Test
    public void test2() {
        int[][] test = new int[][] { {255, 255, 255}, {0, 0, 0} };
        int[][] expectedResult = new int[][] { {0, 0, 0}, {255, 255, 255} };
        assertThat(new Solution().flipImage(test) == expectedResult);
    }
}
