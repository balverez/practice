import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] testArr = new int[] { 1, 9, 3, 4, 5 };
        int target = 14;
        int[] expectedResult = new int[] { 1, 4 };
        assertThat(Solution.twoSum(testArr, target) == expectedResult);
    }
}
