import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] arr = new int[] {4, 3, 1, 4, 2, 1, 4};
        int[] result = new int[] {1,4};
        assertThat(new Solution().findDuplicateNumbers(arr) == result);
    }

    @Test
    public void test2() {
        int[] arr = new int[] {1, 5, 23, 2, 6, 3, 1, 8, 12,3};
        int[] result = new int[] {1, 3};
        assertThat(new Solution().findDuplicateNumbers(arr) == result);
    }
}
