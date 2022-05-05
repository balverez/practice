import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] testArr = new int[] { 2, 1, 5, 1, 3 };
        int k = 3;
        int expectedResult = 9;
        assertThat(new Solution().maxSum(testArr, k) == expectedResult);
    }
}
