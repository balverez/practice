import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] testArr = new int[] { 1, 3, -2, 6, 4 };
        int k = 4;
        double[] expectedResult = new double[] { 2.0, 2.75 };
        assertThat(new Solution().averages(testArr, k) == expectedResult);
    }

    @Test
    public void test2() {
        int[] testArr = new int[] { 1, 3, -2, 6, 4 };
        int k = 1;
        double[] expectedResult = new double[] { 1, 3, -2, 6, 4 };
        assertThat(new Solution().averages(testArr, k) == expectedResult);
    }

    @Test
    public void test3() {
        int[] testArr = new int[] { 1, 3, -2, 6, 4 };
        int k = 5;
        double[] expectedResult = new double[] { 2.4 };
        assertThat(new Solution().averages(testArr, k) == expectedResult);
    }
}
