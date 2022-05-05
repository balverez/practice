import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] arr1 = new int[] { 2, 5, 7, 8, 9 };
        int[] arr2 = new int[] { 9 };
        int[] result = new int[] { 2, 5, 7, 8, 9, 9 };
        assertThat(new Solution().mergeSorted(arr1, arr2) == result);
    }

    @Test
    public void test2() {
        int[] arr1 = new int[] { 7, 8 };
        int[] arr2 = new int[] { 1, 2 };
        int[] result = new int[] { 1, 2, 7, 8 };
        assertThat(new Solution().mergeSorted(arr1, arr2) == result);
    }

    @Test
    public void test3() {
        int[] arr1 = new int[] { 2 };
        int[] arr2 = new int[] { };
        int[] result = new int[] { 2 };
        assertThat(new Solution().mergeSorted(arr1, arr2) == result);
    }

    @Test
    public void test4() {
        int[] arr1 = new int[] { 2, 5, 7, 8 };
        int[] arr2 = new int[] { 2, 4, 5, 12, 32 };
        int[] result = new int[] { 2, 2, 4, 5, 5, 7, 8, 12, 32 };
        assertThat(new Solution().mergeSorted(arr1, arr2) == result);
    }
}
