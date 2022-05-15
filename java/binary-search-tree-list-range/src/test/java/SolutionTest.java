import org.assertj.core.util.Arrays;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.LinkedList;
import java.util.List;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(8, new TreeNode(7), new TreeNode(10));
        TreeNode leftNode = new TreeNode(3, new TreeNode(2), new TreeNode(4));
        TreeNode testRoot = new TreeNode(5, leftNode, rightNode);
        int a = 1;
        int b = 3;
        List<Integer> expected = new LinkedList<>();
        expected.add(2);
        expected.add(3);
        assertThat(expected == new Solution().listInRange(testRoot, a, b));
    }
}
