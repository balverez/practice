import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void test1() {
        ListNode head = new ListNode(1);
        assertThat(new Solution().findMiddle(head) == 1);
    }

    @Test
    public void test2() {
        ListNode head = new ListNode(1);
        head = Solution.insertAtEnd(head, 2);
        assertThat(new Solution().findMiddle(head) == 2);
    }

    @Test
    public void test3() {
        ListNode head = new ListNode(1);
        head = Solution.insertAtEnd(head, 2);
        head = Solution.insertAtEnd(head, 3);
        head = Solution.insertAtEnd(head, 4);
        assertThat(new Solution().findMiddle(head) == 3);
    }

    @Test
    public void test4() {
        ListNode head = new ListNode(1);
        head = Solution.insertAtEnd(head, 2);
        head = Solution.insertAtEnd(head, 3);
        head = Solution.insertAtEnd(head, 4);
        head = Solution.insertAtEnd(head, 5);
        assertThat(new Solution().findMiddle(head) == 3);
    }
}
