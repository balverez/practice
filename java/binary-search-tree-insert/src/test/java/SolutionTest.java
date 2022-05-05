import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(8, new TreeNode(5), new TreeNode(10));
        TreeNode testRoot = new TreeNode(4, new TreeNode(2), rightNode);
        int expectedResult = 6;
        assertThat(new Solution().insert(testRoot, expectedResult).right.left.right.data == expectedResult);
    }
}
