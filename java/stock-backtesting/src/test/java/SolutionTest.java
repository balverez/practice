import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] testArr = new int[] { 50, 100, 20, 80, 20 };
        int expectedResult = 110;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }
}
