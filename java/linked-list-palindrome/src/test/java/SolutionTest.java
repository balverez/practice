import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void test1() {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        assertThat(new Solution().isPalindrome(head) == true);
    }

    @Test
    public void test2() {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(1)));
        assertThat(new Solution().isPalindrome(head) == true);
    }

    @Test
    public void test3() {
        ListNode head = new ListNode(1, new ListNode(2));
        assertThat(new Solution().isPalindrome(head) == false);
    }

    @Test
    public void test4() {
        ListNode head = new ListNode(0);
        assertThat(new Solution().isPalindrome(head) == true);
    }
}
