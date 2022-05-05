import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        ListNode nodes = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(1, new ListNode(2)))));

        int[] expectedData = {1, 2, 3};
        ListNode i = new Solution().removeDuplicates(nodes);
        int j = 0;
        int[] result = new int[3];
        while (i != null)
        {
            result[j++] = i.data;
            i = i.next;
        }

        assertThat(result == expectedData);
    }
}
