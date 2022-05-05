import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[][] test = new int[][] { {255, 0, 0}, {255, 0, 0} };
        int[][] expectedResult = new int[][] { {0, 0, 255}, {0, 0, 255} };
        assertThat(new Solution().mirrorImage(test) == expectedResult);
    }

    @Test
    public void test2() {
        int[][] test = new int[][] { {255, 255, 0}, {225, 225, 0} };
        int[][] expectedResult = new int[][] { {0, 255, 255}, {0, 255, 255} };
        assertThat(new Solution().mirrorImage(test) == expectedResult);
    }

    @Test
    public void test3() {
        int[][] test = new int[][] { {255, 0} };
        int[][] expectedResult = new int[][] { {0, 255} };
        assertThat(new Solution().mirrorImage(test) == expectedResult);
    }
}
