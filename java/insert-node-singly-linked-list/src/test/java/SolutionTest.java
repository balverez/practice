import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void insert() {
        ListNode head = new ListNode(1);
        head = Solution.insertAtEnd(head, 2);
        head = Solution.insertAtEnd(head, 3);
        assertThat(head.next.data == 2);
    }

    @Test
    public void nullCase() {
        ListNode head = Solution.insertAtEnd(null, 1);
        assertThat(head.data == 1);
    }
}
