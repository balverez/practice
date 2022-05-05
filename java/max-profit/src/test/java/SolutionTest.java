import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] testArr = new int[] { 30, 25, 20, 15 };
        int expectedResult = 0;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }

    @Test
    public void test2() {
        int[] testArr = new int[] { 50, 0, 10, 100 };
        int expectedResult = 100;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }

    @Test
    public void test3() {
        int[] testArr = new int[] { 30, 50, 10, 100 };
        int expectedResult = 90;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }

    @Test
    public void test4() {
        int[] testArr = new int[] { 100, 99, 98, 95 };
        int expectedResult = 0;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }

    @Test
    public void test5() {
        int[] testArr = new int[] { 100, 100 };
        int expectedResult = 0;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }

    @Test
    public void test6() {
        int[] testArr = new int[] { 102, 105, 99, 98, 102, 99 };
        int expectedResult = 4;
        assertThat(new Solution().maxProfit(testArr) == expectedResult);
    }
}
