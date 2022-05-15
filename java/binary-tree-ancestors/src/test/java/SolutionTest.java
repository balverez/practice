import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class SolutionTest {
    @Test
    public void test1() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);
        int n = 5;
        List<Integer> expected = Arrays.asList(3, 1);

        assertThat(expected == new Solution().listAncestors(testRoot, n));
    }

    @Test
    public void test2() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);
        int n = 4;
        List<Integer> expected = Arrays.asList(3, 1);

        assertThat(expected == new Solution().listAncestors(testRoot, n));
    }

    @Test
    public void test3() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);
        int n = 3;
        List<Integer> expected = Arrays.asList(1);

        assertThat(expected == new Solution().listAncestors(testRoot, n));
    }

    @Test
    public void test4() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);
        int n = 2;
        List<Integer> expected = Arrays.asList(1);

        assertThat(expected == new Solution().listAncestors(testRoot, n));
    }

    @Test
    public void test5() {
        TreeNode rightNode = new TreeNode(3, new TreeNode(4), new TreeNode(5));
        TreeNode testRoot = new TreeNode(1, new TreeNode(2), rightNode);
        int n = 1;
        List<Integer> expected = new LinkedList<Integer>();

        assertThat(expected == new Solution().listAncestors(testRoot, n));
    }
}
