import org.junit.Test;
import java.util.*;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);

        List<List<Integer>> expectedResult = new LinkedList<>(Arrays.asList(Arrays.asList(1), Arrays.asList(2, 3), Arrays.asList(4, 5)));
        assertThat(new Solution().dumpTree(testRoot) == expectedResult);
    }
}
