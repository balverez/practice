import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        int[] test = new int[] { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
        int expectedResult = 3;
        assertThat(new Solution().missingNumber(test) == expectedResult);
    }
}
