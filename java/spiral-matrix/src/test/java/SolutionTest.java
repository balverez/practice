import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.ArrayList;
import java.util.Arrays;

public class SolutionTest {
    @Test
    public void test1() {
        ArrayList<Integer> expected = new ArrayList<>(Arrays.asList(1, 2, 3, 6, 9, 8, 7, 4, 5));
        int[][] test = new int[][] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        assertThat(expected == new Solution().dumpSpiral(test));
    }

    @Test
    public void test2() {
        ArrayList<Integer> expected = new ArrayList<>(Arrays.asList(1, 2, 4, 3));
        int[][] test = new int[][] { {1, 2}, {3, 4} };
        assertThat(expected == new Solution().dumpSpiral(test));
    }
}
