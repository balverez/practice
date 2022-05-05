import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[][] test = new int[][] { {1, 0}, {0, 0} };
        int[][] expectedResult = new int[][] { {0, 1}, {0, 0} };
        assertThat(new Solution().rotateCounterClockwise(test) == expectedResult);
    }
}
