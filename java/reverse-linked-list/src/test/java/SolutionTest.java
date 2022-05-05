import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {
    @Test
    public void test1() {
        ListNode nodes = new ListNode(1, new ListNode(2, new ListNode(3)));

        int[] expectedData = {3, 2, 1};
        ListNode i = new Solution().reverseList(nodes);
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
