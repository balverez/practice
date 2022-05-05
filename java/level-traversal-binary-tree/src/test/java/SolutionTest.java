import org.junit.Test;
import java.util.*;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);

        LinkedList<Integer> expectedResult = new LinkedList<>(Arrays.asList(1, 2, 3, 4, 5));
        assertThat(new Solution().levelOrder(testRoot) == expectedResult);
    }
}
