import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(8, new TreeNode(5), new TreeNode(10));
        TreeNode testRoot = new TreeNode(4, new TreeNode(2), rightNode);
        int expectedResult = 8;
        assertThat(new Solution().kthSmallest(testRoot, 4) == expectedResult);
    }
}
