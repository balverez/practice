import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        ListNode nodes = new ListNode(1, new ListNode(2, new ListNode(3)));
        int testData = -1;
        int testIndex = 0;

        int[] expectedData = {-1, 1, 2, 3};
        ListNode i = new Solution().insertAtIndex(nodes, testData, testIndex);
        int j = 0;
        int[] result = new int[4];
        while (i != null)
        {
            result[j++] = i.data;
            i = i.next;
        }

        assertThat(result == expectedData);
    }

    @Test
    public void test2() {
        ListNode nodes = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        int testData = -1;
        int testIndex = 5;

        int[] expectedData = {-1, 1, 2, 3};
        ListNode i = new Solution().insertAtIndex(nodes, testData, testIndex);
        int j = 0;
        int[] result = new int[6];
        while (i != null)
        {
            result[j++] = i.data;
            i = i.next;
        }

        assertThat(result == expectedData);
    }
}
