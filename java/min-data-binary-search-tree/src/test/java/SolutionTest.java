import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(15, new TreeNode(14), new TreeNode(16));
        TreeNode testRoot = new TreeNode(10, new TreeNode(5, new TreeNode(4), new TreeNode(6)), rightNode);
        int expectedResult = 4;
        assertThat(new Solution().minData(testRoot) == expectedResult);
    }
}
