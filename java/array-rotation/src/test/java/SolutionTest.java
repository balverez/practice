import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] testArr = new int[] { 1, 2, 3, 4 };
        int k = 1;
        int[] expectedResult = new int[] { 2, 3, 4, 1 };
        assertThat(new Solution().rotateLeft(testArr, k) == expectedResult);
    }

    @Test
    public void test2() {
        int[] testArr = new int[] { 1, 2, 3, 4 };
        int k = 2;
        int[] expectedResult = new int[] { 3, 4, 1, 2 };
        assertThat(new Solution().rotateLeft(testArr, k) == expectedResult);
    }

    @Test
    public void test3() {
        int[] testArr = new int[] { 1, 2, 3, 4 };
        int k = 3;
        int[] expectedResult = new int[] { 4, 1, 2, 3 };
        assertThat(new Solution().rotateLeft(testArr, k) == expectedResult);
    }

    @Test
    public void test4() {
        int[] testArr = new int[] { 1, 2, 3, 4 };
        int k = 4;
        int[] expectedResult = new int[] { 1, 2, 3, 4 };
        assertThat(new Solution().rotateLeft(testArr, k) == expectedResult);
    }

    @Test
    public void test5() {
        int[] testArr = new int[] { 1, 2, 3, 4 };
        int k = 5;
        int[] expectedResult = new int[] { 2, 3, 4, 1 };
        assertThat(new Solution().rotateLeft(testArr, k) == expectedResult);
    }

    @Test
    public void test6() {
        int[] testArr = new int[] { 1, 2, 3, 4 };
        int k = 0;
        int[] expectedResult = new int[] { 1, 2, 3, 4 };
        assertThat(new Solution().rotateLeft(testArr, k) == expectedResult);
    }
}
