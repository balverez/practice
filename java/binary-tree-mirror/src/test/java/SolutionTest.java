import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);

        int expectedResult = 2;
        assertThat(new Solution().minDepth(testRoot) == expectedResult);
    }
}
